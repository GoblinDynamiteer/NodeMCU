#include <ArduinoNodeMCU.h>

/* Command buffer size / lenght */
#define SERIAL_BUFFER_SIZE 10

/* Commands */
const char COMMAND_END = 'X';
const char COMMAND_LED = 'L';

#define RED_LED_PIN PIN_GPIO16

void setup()
{
    Serial.begin(9600);
    delay(10);

    pinMode(RED_LED_PIN, OUTPUT);
    digitalWrite(RED_LED_PIN, HIGH);
}

void loop()
{
    /* Get command from bluetooth serial */
    String data = readSerial();
    byte pwm = 0;

    /* If command is not empty */
    if(data.length() > 0)
    {
        switch (data[0])
        {
            case COMMAND_LED:
                pwm = GetPWMfromCommand(data);
                ledPWM(RED_LED_PIN, pwm);
                Serial.println("Setting RED to: " + String(pwm));
                break;

            default:
                break;
        }
    }
}

/* Set LED PWM value */
void ledPWM(int pin, byte pwm_value)
{
    /* Limit PWM value (not needed as byte is max 255?) */
    pwm_value = pwm_value > 255 ? 255 : pwm_value;

    analogWrite(pin, pwm_value);
}

/* Read serial command (from bluetooth) */
String readSerial()
{
    char command[SERIAL_BUFFER_SIZE + 1];

    byte size = Serial.readBytesUntil(
        COMMAND_END,
        command,
        SERIAL_BUFFER_SIZE
    );

    command[size] = '\0';

    return String(command);
}

/* Get pwm value from command */
byte GetPWMfromCommand(String data)
{
    String pwm = ""; // For int conversion

    for(int i = 1; i < data.length(); i++)
    {
        /* Break when char is non-digit */
        if(!isDigit(data[i]))
        {
            break;
        }

        pwm += data[i]; // Concatenate numbers to string
    }

    return (byte)pwm.toInt();
}
