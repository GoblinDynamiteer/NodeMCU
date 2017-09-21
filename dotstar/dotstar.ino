#include <Arduino.h>
#include <Adafruit_DotStar.h>
#include <ArduinoNodeMCU.h>

/*   Led-strip   */
#define STRIP_NUM_LEDS 50
#define NODEMCU_PIN_DATA D5 // 4
#define NODEMCU_PIN_CLOCK D8 //5
#define STRIP_BRIGHTNESS_MAX 250

/*   Init LED-strip as "strip"  */
Adafruit_DotStar strip = Adafruit_DotStar(
    STRIP_NUM_LEDS,
    NODEMCU_PIN_DATA,
    NODEMCU_PIN_CLOCK,
    DOTSTAR_BRG
  );

void setup()
{
    strip.begin();
    strip.setBrightness(250);
}

void loop()
{
    for(int i = 0; i < STRIP_NUM_LEDS; i++)
    {
        strip.setPixelColor(i, 0,0,255);
        strip.show();
        delay(50);
    }

    for(int i = 0; i < STRIP_NUM_LEDS; i++)
    {
        strip.setPixelColor(i, 0,255,0);
        strip.show();
        delay(50);
    }

    for(int i = 0; i < STRIP_NUM_LEDS; i++)
    {
        strip.setPixelColor(i, 255,0,0);
        strip.show();
        delay(50);
    }
}
