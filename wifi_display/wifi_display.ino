#include <ESP8266WiFi.h>
#include <ArduinoNodeMCU.h>
#include <WiFiSettings.h> // SSID & Password
#include <Wire.h>
#include "SSD1306.h"

#define STRING_NOT_FOUND -1
#define LINE_HEIGHT 15

String toggle_red = "/TOGGLE-RED";
String toggle_blue = "/TOGGLE-BLUE";

WiFiServer server(80);
WiFiClient client;

SSD1306  display(0x3c, D3, D5);

void setup()
{
    display.init();
    display.flipScreenVertically();
    display.setTextAlignment(TEXT_ALIGN_LEFT);
    display.setFont(ArialMT_Plain_10);

    Serial.begin(115200);
    delay(10);

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

/* Write text to display */
void setText(String text, int x = 0, int y = 0)
{
    display.clear();
    display.drawString(x, y, text);
    display.display();
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

    if(request.indexOf("settext=") != STRING_NOT_FOUND)
    {
        request.replace("GET /action_page.php?settext=", "");
        request.replace(" HTTP/1.1", "");

        setText(request);
    }

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
    client.println("<title>SET TEXT!</title>");
    client.println("<h1>SET TEXT!</h1>");

    client.println("<form action=\"/action_page.php\">");
    client.println("Text:<br>");
    client.println("<input type=\"text\" name=\"settext\" value=\"HELLO\">");
    client.println("<br><br>");
    client.println("<input type=\"submit\" value=\"Submit\">");
    client.println("</form>");

    client.println("</html>");
}
