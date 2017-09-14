/*
    NodeMCU Arduino sketch
    Draw pixels on SSD1306-display from PC-app

    by Johan Kampe

    Hookup:
    SSD1306     SDA D2
    SSD1306     SCL D1
    HC-06       RX  TX
    HC-06       TX  RX

 */

#include <Wire.h>
#include "SSD1306.h"
#include "ArduinoNodeMCU.h"

#define SERIAL_BUFFER_SIZE 30

#define RESOLUTION_X 128
#define RESOLUTION_Y 64

#define DISPLAY_BUFFER_SIZE (RESOLUTION_X * RESOLUTION_Y)
const char COMMAND_END = '\n';

bool update;

char * display_buffer;

SSD1306 display(0x3c, SDA, SCL);

void setup()
{
    display.init();
    display.flipScreenVertically();
    display.setTextAlignment(TEXT_ALIGN_LEFT);
    display.setFont(ArialMT_Plain_10);

    Serial.begin(9600);
    delay(10);

    display_buffer = (char *)malloc(DISPLAY_BUFFER_SIZE + 1);
    update = false;
}

void loop()
{
    /* Get command from bluetooth serial */
    readSerial();

    if(update)
    {
        updateScreen();
        update = false;
    }
}

/* Read serial command (from bluetooth) */
char * readSerial()
{
    int command_size = Serial.readBytesUntil(
        COMMAND_END,
        display_buffer,
        DISPLAY_BUFFER_SIZE
    );

    if(command_size > 0)
    {
        Serial.println("Got data: " + String(command_size));
        update = true;
    }
}

/* Write pixels to display */
void updateScreen()
{
    display.drawXbm(0, 0, RESOLUTION_X, RESOLUTION_Y, display_buffer);
    display.display();

    display.clear();
}
