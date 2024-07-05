#include <LiquidCrystal_I2C.h>
#include <WiFi.h>
#include <DHT.h>

#define DHTPIN 26
#define DHTTYPE DHT22

DHT dht(DHTPIN, DHTTYPE);

LiquidCrystal_I2C LCD = LiquidCrystal_I2C(0x27, 16, 2);

void leituraSENSOR(float& temperatura, float& umidade)
{
  temperatura = dht.readTemperature();
  umidade = dht.readHumidity();
}


void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  dht.begin();

  LCD.init();
  LCD.backlight();
  LCD.clear();

}

void loop() {
    delay(5000);
    LCD.setCursor(0,0);
    float temperatura, umidade;
    leituraSENSOR(temperatura, umidade);

    LCD.print("Temperatura " + (String)temperatura);

    LCD.setCursor(0,1);
    LCD.print("Umidade " + (String)umidade + "%" );

  
  

    
  

}
