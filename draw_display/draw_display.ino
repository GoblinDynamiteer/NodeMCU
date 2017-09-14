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

bool buffer[DISPLAY_BUFFER_SIZE];

bool update;

const char test_bits[] = {
0x13, 0x00, 0x15, 0x00, 0x93, 0xcd, 0x55, 0xa5, 0x93, 0xc5, 0x00, 0x80,
0x00, 0x60 };

SSD1306 display(0x3c, SDA, SCL);

void setup()
{
    display.init();
    display.flipScreenVertically();
    display.setTextAlignment(TEXT_ALIGN_LEFT);
    display.setFont(ArialMT_Plain_10);

    Serial.begin(9600);
    delay(10);

    updateScreen();

    update = false;
}

void loop()
{
    /* Get command from bluetooth serial */
    char * data;
    data = readSerial();

    /* Switch on first char in sent command */
    switch (data[0])
    {
        case 'C': // Clear/Reset

            update = true;

            break;

        default:
            break;
    }

    if(update)
    {
        updateScreen();
        update = false;
    }
}

/* Read serial command (from bluetooth) */
char * readSerial()
{
    char command[SERIAL_BUFFER_SIZE + 1];

    int command_size = Serial.readBytesUntil(
        COMMAND_END,
        command,
        SERIAL_BUFFER_SIZE
    );

    if(command_size > 0)
    {
        command[command_size] = '\0';
        return command;
    }

    return "0";

}

/* Write pixels to display */
void updateScreen()
{
    display.clear();

    // Draw a XBM
    //void drawXbm(int16_t x, int16_t y, int16_t width, int16_t height, const char* xbm);
    display.drawXbm(0, 0, 16, 7, test_bits);

    display.display();
}
