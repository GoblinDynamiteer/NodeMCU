#include <Arduino.h>
#include <Adafruit_DotStar.h>
#include <ArduinoNodeMCU.h>

#define STRIP_NUM_LEDS 48
#define NODEMCU_PIN_DATA D5 // 4 // Arduino
#define NODEMCU_PIN_CLOCK D8 // 5 // Arduino
#define STRIP_BRIGHTNESS_MAX 250

unsigned long timer;
int strip_delay;
int current_led;
uint8_t current_mode;
uint8_t pixel_color[3];
String serial_data, serial_data_value;
bool serial_data_complete;
bool update;

enum{ RED, GREEN, BLUE };
enum{
    MODE_BREATHER,
    MODE_CHASER,
    MODE_STATIC,
    MODE_MANUAL,
    MODE_GRADIENT,
    MAX_MODES
};

const String mode_name [] = {
    "Breather",
    "Chaser",
    "Static",
    "Manual",
    "Gradient"
};

Adafruit_DotStar strip = Adafruit_DotStar(
    STRIP_NUM_LEDS,
    NODEMCU_PIN_DATA,
    NODEMCU_PIN_CLOCK,
    DOTSTAR_RGB
  );

void (*strip_mode[5])(void);

void setup()
{
    Serial.begin(9600);

    serial_data = "";
    serial_data_value = "";
    serial_data.reserve(20);
    serial_data_value.reserve(20);
    serial_data_complete = false;

    strip.begin();
    strip.setBrightness(250);

    timer = millis();
    strip_delay = 30;
    current_led = 0;
    current_mode = MODE_BREATHER;

    pixel_color[RED] = 0;
    pixel_color[GREEN] = 200;
    pixel_color[BLUE] = 0;

    strip_mode[MODE_BREATHER] = led_mode_breather;
    strip_mode[MODE_CHASER] = led_mode_chaser;
    strip_mode[MODE_STATIC] = led_mode_single_color;
    strip_mode[MODE_MANUAL] = led_mode_manual;
    strip_mode[MODE_GRADIENT] = led_mode_gradient;

    update = true;
}


void loop()
{
    strip_mode[current_mode]();
    serialEvent();

    if(serial_data_complete)
    {
        handle_command();
    }
}

/* Read serial Data */
void serialEvent()
{
    while (Serial.available())
    {
        char read_byte = (char)Serial.read();
        serial_data += read_byte;

        if(isDigit(read_byte)) // Catch digits
        {
            serial_data_value += read_byte;
        }

        if (read_byte == '\n')
        {
            serial_data_complete = true;
        }
    }
}

/* Convert byte RGB values to single int */
uint32_t get_color(void)
{
    return
        0x000000 |
        (uint32_t)(pixel_color[BLUE] << 16) |
        (uint32_t)(pixel_color[GREEN] << 8) |
        (uint32_t)(pixel_color[RED]);
}

/* Manual mode, controlled with Serial commands */
void led_mode_manual(void)
{
    return;
}

void led_mode_gradient(void)
{
    if(update)
    {
        int pwm_value = 0;
        /* Find highest value PWM */
        for(int i = 0; i < 3; i++)
        {
            if(pixel_color[i] > pwm_value)
            {
                pwm_value = pixel_color[i];
            }
        }

        int step = (int)((float)pwm_value / (float)STRIP_NUM_LEDS + 0.5);
        Serial.println("Gradient step: " + String(step));

        for(int i = 0; i < STRIP_NUM_LEDS; i++)
        {
            strip.setPixelColor(i, get_color());

            for(int i = 0; i < 3; i++)
            {
                pixel_color[i] = pixel_color[i] - step > 0 ?
                    (pixel_color[i] - step) : 0;
            }
        }

        strip.show();

        update = false;
    }
}

/* Static mode, shows same color on all pxiels */
void led_mode_single_color(void)
{
    if(update)
    {
        for(int i = 0; i < STRIP_NUM_LEDS; i++)
        {
            strip.setPixelColor(i, get_color());
        }

        strip.show();

        update = false;
    }
}

/* Fade current color up/down */
void led_mode_breather(void)
{
    static bool fade_up = false;
    static int step = 2;

    if(millis() - timer >= strip_delay)
    {
        for(int i = 0; i < STRIP_NUM_LEDS; i++)
        {
            strip.setPixelColor(i, get_color());
        }

        strip.show();

        for(int i = 0; i < 3; i++)
        {
            if(pixel_color[i])
            {
                pixel_color[i] = fade_up ?
                    pixel_color[i] + step :
                    pixel_color[i] - step;

                if(pixel_color[i] < (step + 1) || pixel_color[i] > 200)
                {
                    fade_up = !fade_up;
                }
            }
        }

        timer = millis();
    }
}

/* Run R-G-B sequences on strip */
void led_mode_chaser(void)
{
    if(millis() - timer >= strip_delay)
    {
        strip.setPixelColor(
            current_led++,
            get_color()
        );

        strip.show();

        if(current_led >= STRIP_NUM_LEDS)
        {
            current_led = 0;
            swap_rgb();
        }

        timer = millis();
    }
}

/* Swaps R->G->B */
void swap_rgb(void)
{
    if(pixel_color[RED])
    {
        pixel_color[GREEN] = pixel_color[RED];
        pixel_color[RED] = 0;
        pixel_color[BLUE] = 0;
        return;
    }

    if(pixel_color[GREEN])
    {
        pixel_color[BLUE] = pixel_color[GREEN];
        pixel_color[RED] = 0;
        pixel_color[GREEN] = 0;
        return;
    }

    if(pixel_color[BLUE])
    {
        pixel_color[RED] = pixel_color[BLUE];
        pixel_color[GREEN] = 0;
        pixel_color[BLUE] = 0;
    }
}

void handle_command(void)
{
    Serial.println("Got command " + serial_data);

    char command = serial_data[0];
    int value = serial_data_value.toInt();

    switch(command)
    {
        case 'R':
            pixel_color[RED] = value > 255 ? 255 : value;
            break;

        case 'G':
            pixel_color[GREEN] = value > 255 ? 255 : value;
            break;

        case 'B':
            pixel_color[BLUE] = value > 255 ? 255 : value;
            break;

        case 'S': // Speed / delay
            if(value > 0)
            {
                strip_delay = value;
            }
            break;

        case 'M': // Mode
            if(value >= 0 && value < MAX_MODES)
            {
                current_mode = value;
            }
            break;

        case 'Q': // Query
            Serial.println("Connected to DotStar controller!");
            Serial.println("Current mode: " + mode_name[current_mode]);
            Serial.println("Color: R"
                + String(pixel_color[RED]) + " G"
                + String(pixel_color[GREEN]) + " B"
                + String(pixel_color[BLUE]));
            break;

        case 'P': // Set pixel in manual mode
        {
            if(current_mode == MODE_MANUAL
                && value >= 0 && value < STRIP_NUM_LEDS)
            {
                strip.setPixelColor(value, get_color());
                strip.show();
            }
            break;
        }

        case 'C': // Clear pixel in manual mode
        {
            if(current_mode == MODE_MANUAL
                && value >= 0 && value < STRIP_NUM_LEDS)
            {
                strip.setPixelColor(value, 0x000000);
                strip.show();
            }
            break;
        }

        default:
            break;
    }

    serial_data = "";
    serial_data_value = "";
    serial_data_complete = false;
    update = true;
}
