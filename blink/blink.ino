#include "ArduinoNodeMCU.h"

#define RED_LED_PIN PIN_GPIO16
#define BLUE_LED_PIN PIN_GPIO5

void setup()
{
    pinMode(RED_LED_PIN, OUTPUT);
    pinMode(BLUE_LED_PIN, OUTPUT);
}


void loop()
{
    digitalWrite(RED_LED_PIN, HIGH);
    digitalWrite(BLUE_LED_PIN, LOW);

    delay(1000);

    digitalWrite(RED_LED_PIN, LOW);
    digitalWrite(BLUE_LED_PIN, HIGH);

    delay(1000);
}
