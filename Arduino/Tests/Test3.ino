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

void setup()
{
  DefineDigitalPins();

  digitalWrite(_vin1Pin, 0);
  digitalWrite(_vin2Pin, 0);

//  SetCurrent_50();
  SetCurrent_100();
//  SetCurrent_150();
//  SetCurrent_200(); 
//  SetCurrent_250();
//  SetCurrent_300();
//  SetCurrent_350();
//  SetCurrent_400();
//  SetCurrent_450();
//  SetCurrent_500();
//  SetCurrent_550();
//  SetCurrent_600();
//  SetCurrent_650();
}

void loop() {
  //Routine1();
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
  digitalWrite(Ladder_3, 0);
  digitalWrite(Ladder_4, 0);
  digitalWrite(Ladder_5, 1);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 0);
}

void SetCurrent_100() {
  digitalWrite(Ladder_0, 1);
  digitalWrite(Ladder_1, 0);
  digitalWrite(Ladder_2, 0);
  digitalWrite(Ladder_3, 1);
  digitalWrite(Ladder_4, 0);
  digitalWrite(Ladder_5, 1);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 0);
}

void SetCurrent_150() {
  digitalWrite(Ladder_0, 0);
  digitalWrite(Ladder_1, 1);
  digitalWrite(Ladder_2, 0);
  digitalWrite(Ladder_3, 0);
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
  digitalWrite(Ladder_4, 1);
  digitalWrite(Ladder_5, 1);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 0);
}

void SetCurrent_250() {
  digitalWrite(Ladder_0, 0);
  digitalWrite(Ladder_1, 1);
  digitalWrite(Ladder_2, 1);
  digitalWrite(Ladder_3, 1);
  digitalWrite(Ladder_4, 1);
  digitalWrite(Ladder_5, 0);
  digitalWrite(Ladder_6, 1);
  digitalWrite(Ladder_7, 0);
}

void SetCurrent_300() {
  digitalWrite(Ladder_0, 1);
  digitalWrite(Ladder_1, 1);
  digitalWrite(Ladder_2, 0);
  digitalWrite(Ladder_3, 1);
  digitalWrite(Ladder_4, 0);
  digitalWrite(Ladder_5, 1);
  digitalWrite(Ladder_6, 1);
  digitalWrite(Ladder_7, 0);
}

void SetCurrent_350() {
  digitalWrite(Ladder_0, 1);
  digitalWrite(Ladder_1, 1);
  digitalWrite(Ladder_2, 0);
  digitalWrite(Ladder_3, 0);
  digitalWrite(Ladder_4, 0);
  digitalWrite(Ladder_5, 0);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 1);
}

void SetCurrent_400() {
  digitalWrite(Ladder_0, 0);
  digitalWrite(Ladder_1, 1);
  digitalWrite(Ladder_2, 0);
  digitalWrite(Ladder_3, 1);
  digitalWrite(Ladder_4, 0);
  digitalWrite(Ladder_5, 0);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 1);
}

void SetCurrent_450() {
 digitalWrite(Ladder_0, 1);
  digitalWrite(Ladder_1, 1);
  digitalWrite(Ladder_2, 0);
  digitalWrite(Ladder_3, 0);
  digitalWrite(Ladder_4, 1);
  digitalWrite(Ladder_5, 0);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 1);
}

void SetCurrent_500() {
 digitalWrite(Ladder_0, 1);
  digitalWrite(Ladder_1, 1);
  digitalWrite(Ladder_2, 0);
  digitalWrite(Ladder_3, 1);
  digitalWrite(Ladder_4, 1);
  digitalWrite(Ladder_5, 0);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 1);
}

void SetCurrent_550() {
  digitalWrite(Ladder_0, 0);
  digitalWrite(Ladder_1, 0);
  digitalWrite(Ladder_2, 1);
  digitalWrite(Ladder_3, 0);
  digitalWrite(Ladder_4, 0);
  digitalWrite(Ladder_5, 1);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 1);
}

void SetCurrent_600() {
 digitalWrite(Ladder_0, 0);
  digitalWrite(Ladder_1, 0);
  digitalWrite(Ladder_2, 1);
  digitalWrite(Ladder_3, 1);
  digitalWrite(Ladder_4, 0);
  digitalWrite(Ladder_5, 1);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 1);
}

void SetCurrent_650() {
 digitalWrite(Ladder_0, 1);
  digitalWrite(Ladder_1, 1);
  digitalWrite(Ladder_2, 1);
  digitalWrite(Ladder_3, 0);
  digitalWrite(Ladder_4, 1);
  digitalWrite(Ladder_5, 1);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 1);
}

void Routine1()
{
  digitalWrite(_vin1Pin, 0);
  digitalWrite(_vin2Pin, 0);
  delay(3000);

  //  digitalWrite(_ledPin, 0);

  //  digitalWrite(_vin1Pin, 1);
  //  digitalWrite(_vin2Pin, 0);
  //  delay(3000);
  //
  //  digitalWrite(_ledPin, 1);
  //  delay(50);
  //  digitalWrite(_ledPin, 0);
  //  delay(50);
  //  digitalWrite(_ledPin, 1);
  //
  //  digitalWrite(_vin2Pin, 1);
  //  digitalWrite(_vin1Pin, 1);
  //  delay(3000);
  //
  //  digitalWrite(_ledPin, 1);
  //
  //  digitalWrite(_vin2Pin, 1);
  //  digitalWrite(_vin1Pin, 0);
  //  delay(3000);
}
