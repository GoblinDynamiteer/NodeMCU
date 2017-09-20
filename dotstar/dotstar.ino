#include <Arduino.h>
#include <Adafruit_DotStar.h>
#include <ArduinoNodeMCU.h>

/*   Led-strip   */
#define STRIP_NUM_LEDS 10
#define NODEMCU_PIN_DATA D5
#define NODEMCU_PIN_CLOCK D8
#define STRIP_BRIGHTNESS_MAX 250

/*   Init LED-strip as "strip"  */
Adafruit_DotStar strip = Adafruit_DotStar(
    STRIP_NUM_LEDS,
    NODEMCU_PIN_DATA,
    NODEMCU_PIN_CLOCK,
    DOTSTAR_RGB
  );

void setup()
{
    strip.begin();
    strip.setPixelColor(1, 0xFF0000);
    strip.setPixelColor(2, 0xFF0000);
    strip.setPixelColor(3, 0xFF0000);
    strip.show();
}

void loop()
{
    delay(1);
}
