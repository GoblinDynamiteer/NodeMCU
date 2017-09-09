#include <ESP8266WiFi.h>
#include <ArduinoNodeMCU.h>
#include <WiFiSettings.h> // SSID & Password

#define RED_LED_PIN PIN_GPIO16
#define BLUE_LED_PIN PIN_GPIO5
#define STRING_NOT_FOUND -1

String toggle_red = "/TOGGLE-RED";
String toggle_blue = "/TOGGLE-BLUE";

bool red_status;
bool blue_status;

WiFiServer server(80);
WiFiClient client;

void setup()
{
    Serial.begin(115200);
    delay(10);

    pinMode(RED_LED_PIN, OUTPUT);
    pinMode(BLUE_LED_PIN, OUTPUT);

    digitalWrite(RED_LED_PIN, LOW);
    digitalWrite(BLUE_LED_PIN, LOW);

    blue_status = false;
    red_status = false;

    /* Connect to WiFi */
    WiFi.begin(WIFI_SSID, WIFI_PASSWORD);
    Serial.print("Connecting");

    while (WiFi.status() != WL_CONNECTED)
    {
        delay(500);
        Serial.print(".");
    }

    Serial.println("Connected to Wifi!");

    /* Start server */
    server.begin();
    Serial.print("Server started at IP: ");
    Serial.println(WiFi.localIP());

}

void loop()
{
    /* Check for new client connected to server */
    client = server.available();

    if (!client)
    {
        return;
    }

    while(!client.available())
    {
        delay(1);
    }

    /* Read request */
    String request = client.readStringUntil('\r');
    Serial.println(request);
    client.flush();

    /* Set LEDs */
    red_status = (request.indexOf(toggle_red) != STRING_NOT_FOUND) ?
        !red_status : red_status;

    blue_status = (request.indexOf(toggle_blue) != STRING_NOT_FOUND) ?
        !blue_status : blue_status;

    digitalWrite(RED_LED_PIN, red_status ? HIGH : LOW);
    digitalWrite(BLUE_LED_PIN, blue_status ? HIGH : LOW);

    clientResponse(); // Show webpage

    delay(1);
    Serial.println("Client disonnected");
    Serial.println("");
}

void clientResponse()
{
    client.println("HTTP/1.1 200 OK");
    client.println("Content-Type: text/html");
    client.println("");
    client.println("<!DOCTYPE HTML>");

    /* HTML */
    client.println("<html>");
    client.println("<title>LED TOGGLER!</title>");
    client.println("<h1>LED TOGGLER!</h1>");

    /* Status */
    client.print("<br>RED: ");
    client.print(red_status ? "ON" : "OFF");
    client.print("<br>BLUE: ");
    client.print(blue_status ? "ON" : "OFF");

    client.println("<br><br>");

    /* Buttons for toggling LEDs */
    client.println("<a href=\"" + toggle_red +
        "\"\"><button>Toggle RED</button></a>");
    client.println("<a href=\"" + toggle_blue +
        "\"\"><button>Toggle BLUE</button></a><br />");

    client.println("</html>");
}
