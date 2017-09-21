#include <Arduino.h>
#include <Adafruit_DotStar.h>
#include <ArduinoNodeMCU.h>

/*   Led-strip   */
#define STRIP_NUM_LEDS 50
#define NODEMCU_PIN_DATA D5 // 4
#define NODEMCU_PIN_CLOCK D8 //5
#define STRIP_BRIGHTNESS_MAX 250

unsigned long timer;
int strip_delay;
int current_led;
int current_color;

/*   Init LED-strip as "strip"  */
Adafruit_DotStar strip = Adafruit_DotStar(
    STRIP_NUM_LEDS,
    NODEMCU_PIN_DATA,
    NODEMCU_PIN_CLOCK,
    DOTSTAR_BRG
  );

void (*strip_mode)(void);

void setup()
{
    strip.begin();
    strip.setBrightness(250);

    timer = millis();
    strip_delay = 30;
    current_led = 0;
    current_color = strip.Color(0, 0, 200);

    strip_mode = led_mode_chaser;
}


void loop()
{
    strip_mode();
}

void led_mode_chaser(void)
{
    if(millis() - timer >= strip_delay)
    {
        strip.setPixelColor(
            current_led++,
            current_color
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
    if(current_color & 0xff0000)
    {
        current_color = 0x0000ff;
        return;
    }

    current_color = current_color << 8;
}
