/*
uint8_t Ladder_0 = 9;
uint8_t Ladder_1 = 8;
uint8_t Ladder_2 = 7;
uint8_t Ladder_3 = 6;
uint8_t Ladder_4 = 5;
uint8_t Ladder_5 = 4;
uint8_t Ladder_6 = 3;
uint8_t Ladder_7 = 2;

uint8_t _vin2Pin = 11;
uint8_t _vin1Pin = 12;
uint8_t _ledPin = 13;

#define value 1
void setup()
{
  DefineDigitalPins();

  digitalWrite(_vin1Pin, value);
  digitalWrite(_vin2Pin, value);

  SetCurrent_600();
}

void loop() {
  //Routine1();
  Routine2();
}

void DefineDigitalPins() {
  pinMode(Ladder_0, OUTPUT);
  pinMode(Ladder_1, OUTPUT);
  pinMode(Ladder_2, OUTPUT);
  pinMode(Ladder_3, OUTPUT);
  pinMode(Ladder_4, OUTPUT);
  pinMode(Ladder_5, OUTPUT);
  pinMode(Ladder_6, OUTPUT);
  pinMode(Ladder_7, OUTPUT);

  pinMode(_vin2Pin, OUTPUT);
  pinMode(_vin1Pin, OUTPUT);
  pinMode(_ledPin, OUTPUT);
}

void SetCurrent_50() {
  digitalWrite(Ladder_0, 0);
  digitalWrite(Ladder_1, 0);
  digitalWrite(Ladder_2, 0);
  digitalWrite(Ladder_3, 1);
  digitalWrite(Ladder_4, 0);
  digitalWrite(Ladder_5, 1);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 0);
}

void SetCurrent_100() {
  digitalWrite(Ladder_0, 1);
  digitalWrite(Ladder_1, 1);
  digitalWrite(Ladder_2, 0);
  digitalWrite(Ladder_3, 0);
  digitalWrite(Ladder_4, 1);
  digitalWrite(Ladder_5, 1);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 0);
}

void SetCurrent_150() {
  digitalWrite(Ladder_0, 1);
  digitalWrite(Ladder_1, 0);
  digitalWrite(Ladder_2, 1);
  digitalWrite(Ladder_3, 1);
  digitalWrite(Ladder_4, 1);
  digitalWrite(Ladder_5, 1);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 0);
}

void SetCurrent_200() {
  digitalWrite(Ladder_0, 0);
  digitalWrite(Ladder_1, 0);
  digitalWrite(Ladder_2, 0);
  digitalWrite(Ladder_3, 1);
  digitalWrite(Ladder_4, 0);
  digitalWrite(Ladder_5, 0);
  digitalWrite(Ladder_6, 1);
  digitalWrite(Ladder_7, 0);
}

void SetCurrent_250() {
  digitalWrite(Ladder_0, 1);
  digitalWrite(Ladder_1, 0);
  digitalWrite(Ladder_2, 0);
  digitalWrite(Ladder_3, 0);
  digitalWrite(Ladder_4, 1);
  digitalWrite(Ladder_5, 0);
  digitalWrite(Ladder_6, 1);
  digitalWrite(Ladder_7, 0);
}

void SetCurrent_300() {
  digitalWrite(Ladder_0, 0);
  digitalWrite(Ladder_1, 1);
  digitalWrite(Ladder_2, 0);
  digitalWrite(Ladder_3, 1);
  digitalWrite(Ladder_4, 1);
  digitalWrite(Ladder_5, 0);
  digitalWrite(Ladder_6, 1);
  digitalWrite(Ladder_7, 0);
}

void SetCurrent_350() {
  digitalWrite(Ladder_0, 1);
  digitalWrite(Ladder_1, 1);
  digitalWrite(Ladder_2, 0);
  digitalWrite(Ladder_3, 0);
  digitalWrite(Ladder_4, 0);
  digitalWrite(Ladder_5, 1);
  digitalWrite(Ladder_6, 1);
  digitalWrite(Ladder_7, 0);
}

void SetCurrent_400() {
  digitalWrite(Ladder_0, 0);
  digitalWrite(Ladder_1, 0);
  digitalWrite(Ladder_2, 1);
  digitalWrite(Ladder_3, 1);
  digitalWrite(Ladder_4, 0);
  digitalWrite(Ladder_5, 1);
  digitalWrite(Ladder_6, 1);
  digitalWrite(Ladder_7, 0);
}

void SetCurrent_450() {
  digitalWrite(Ladder_0, 0);
  digitalWrite(Ladder_1, 1);
  digitalWrite(Ladder_2, 1);
  digitalWrite(Ladder_3, 0);
  digitalWrite(Ladder_4, 1);
  digitalWrite(Ladder_5, 1);
  digitalWrite(Ladder_6, 1);
  digitalWrite(Ladder_7, 0);
}

void SetCurrent_500() {
  digitalWrite(Ladder_0, 0);
  digitalWrite(Ladder_1, 0);
  digitalWrite(Ladder_2, 1);
  digitalWrite(Ladder_3, 0);
  digitalWrite(Ladder_4, 0);
  digitalWrite(Ladder_5, 0);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 1);
}

void SetCurrent_550() {
  digitalWrite(Ladder_0, 0);
  digitalWrite(Ladder_1, 1);
  digitalWrite(Ladder_2, 1);
  digitalWrite(Ladder_3, 1);
  digitalWrite(Ladder_4, 0);
  digitalWrite(Ladder_5, 0);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 1);
}

void SetCurrent_600() {
  digitalWrite(Ladder_0, 1);
  digitalWrite(Ladder_1, 0);
  digitalWrite(Ladder_2, 0);
  digitalWrite(Ladder_3, 1);
  digitalWrite(Ladder_4, 1);
  digitalWrite(Ladder_5, 0);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 1);
}

void SetCurrent_650() {
  digitalWrite(Ladder_0, 1);
  digitalWrite(Ladder_1, 0);
  digitalWrite(Ladder_2, 1);
  digitalWrite(Ladder_3, 0);
  digitalWrite(Ladder_4, 0);
  digitalWrite(Ladder_5, 1);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 1);
}

void Routine2()
{
  digitalWrite(_vin1Pin, 0);
  digitalWrite(_vin2Pin, 0);
  delayMicroseconds(100);
  //delay(1000);
  digitalWrite(_vin1Pin, 0);
  digitalWrite(_vin2Pin, 1);  
  delay(250);
  //delay(1000);
}


void Routine1()
{
  for (int i = 0; i < 13; i++)
  {
    if (i == 0)  SetCurrent_50();
    else if (i == 1) SetCurrent_100();
    else if (i == 2) SetCurrent_150();
    else if (i == 3) SetCurrent_200();
    else if (i == 4) SetCurrent_250();
    else if (i == 5) SetCurrent_300();
    else if (i == 6) SetCurrent_350();
    else if (i == 7) SetCurrent_400();
    else if (i == 8) SetCurrent_450();
    else if (i == 9) SetCurrent_500();
    else if (i == 10) SetCurrent_550();
    else if (i == 11) SetCurrent_600();
    else if (i == 12) SetCurrent_650();
    BlinkLed();
    delay(2400);
  }
}

void BlinkLed() {
  digitalWrite(_ledPin, 0);
  delay(300);
  digitalWrite(_ledPin, 1);
  delay(300);
  digitalWrite(_ledPin, 0);
}
*/
