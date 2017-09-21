#include <Arduino.h>
#include <Adafruit_DotStar.h>
#include <ArduinoNodeMCU.h>

#define STRIP_NUM_LEDS 50
#define NODEMCU_PIN_DATA D5 // 4
#define NODEMCU_PIN_CLOCK D8 //5
#define STRIP_BRIGHTNESS_MAX 250

unsigned long timer;
int strip_delay;
int current_led;
uint8_t current_color[3];

enum{ BLUE, GREEN, RED };

Adafruit_DotStar strip = Adafruit_DotStar(
    STRIP_NUM_LEDS,
    NODEMCU_PIN_DATA,
    NODEMCU_PIN_CLOCK,
    DOTSTAR_RGB
  );

void (*strip_mode[3])(void);

void setup()
{
    Serial.begin(9600);
    
    strip.begin();
    strip.setBrightness(250);

    timer = millis();
    strip_delay = 30;
    current_led = 0;

    current_color[RED] = 0;
    current_color[GREEN] = 200;
    current_color[BLUE] = 0;

    strip_mode[0] = led_mode_breather;
    strip_mode[1] = led_mode_chaser;
    strip_mode[2] = led_mode_chaser;
}


void loop()
{
    strip_mode[0]();
}

void led_mode_breather(void)
{
    static bool fade_up = false;
    static int step = 5;

    if(millis() - timer >= strip_delay)
    {
        for(int i = 0; i < STRIP_NUM_LEDS; i++)
        {
            strip.setPixelColor(i, get_color());
        }

        strip.show();

        for(int i = 0; i < 3; i++)
        {
            if(current_color[i])
            {
                current_color[i] = fade_up ?
                    current_color[i] + step :
                    current_color[i] - step;

                if(current_color[i] < 20 || current_color[i] > 200)
                {
                    fade_up = !fade_up;
                }
            }
        }

        timer = millis();
    }
}

uint32_t get_color(void)
{
    return
        0x000000 |
        (uint32_t)(current_color[RED] << 16) |
        (uint32_t)(current_color[GREEN] << 8) |
        (uint32_t)(current_color[BLUE]);
}

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
    if(current_color[RED])
    {
        current_color[GREEN] = current_color[RED];
        current_color[RED] = 0;
        current_color[BLUE] = 0;
        return;
    }

    if(current_color[GREEN])
    {
        current_color[BLUE] = current_color[GREEN];
        current_color[RED] = 0;
        current_color[GREEN] = 0;
        return;
    }

    if(current_color[BLUE])
    {
        current_color[RED] = current_color[BLUE];
        current_color[GREEN] = 0;
        current_color[BLUE] = 0;
    }
}
