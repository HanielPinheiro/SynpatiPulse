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
  SetCurrent_75();
}

void Routine()
{
  digitalWrite(_vin1Pin, 0);
  digitalWrite(_vin2Pin, 0);
  delayMicroseconds(100);

  digitalWrite(_vin1Pin, 0);
  digitalWrite(_vin2Pin, 1);
  delay(10);

  digitalWrite(_vin1Pin, 1);
  digitalWrite(_vin2Pin, 1);
  delayMicroseconds(100);

  digitalWrite(_vin1Pin, 0);
  digitalWrite(_vin2Pin, 1);
  delay(10);
}

void loop() {
  Routine();
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

void SetCurrent_0() {
  digitalWrite(Ladder_0, 0);
  digitalWrite(Ladder_1, 0);
  digitalWrite(Ladder_2, 0);
  digitalWrite(Ladder_3, 0);
  digitalWrite(Ladder_4, 0);
  digitalWrite(Ladder_5, 0);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 0);
}

void SetCurrent_15() {
  digitalWrite(Ladder_0, 1);
  digitalWrite(Ladder_1, 1);
  digitalWrite(Ladder_2, 0);
  digitalWrite(Ladder_3, 0);
  digitalWrite(Ladder_4, 0);
  digitalWrite(Ladder_5, 1);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 0);
}

void SetCurrent_25() {
  digitalWrite(Ladder_0, 0);
  digitalWrite(Ladder_1, 0);
  digitalWrite(Ladder_2, 1);
  digitalWrite(Ladder_3, 0);
  digitalWrite(Ladder_4, 0);
  digitalWrite(Ladder_5, 1);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 0);
}
void SetCurrent_50() {
  digitalWrite(Ladder_0, 1);
  digitalWrite(Ladder_1, 0);
  digitalWrite(Ladder_2, 1);
  digitalWrite(Ladder_3, 0);
  digitalWrite(Ladder_4, 0);
  digitalWrite(Ladder_5, 1);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 0);
}
void SetCurrent_75() {
  digitalWrite(Ladder_0, 0);
  digitalWrite(Ladder_1, 1);
  digitalWrite(Ladder_2, 1);
  digitalWrite(Ladder_3, 0);
  digitalWrite(Ladder_4, 0);
  digitalWrite(Ladder_5, 1);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 0);
}

void SetCurrent_100() {
  digitalWrite(Ladder_0, 1);
  digitalWrite(Ladder_1, 1);
  digitalWrite(Ladder_2, 1);
  digitalWrite(Ladder_3, 0);
  digitalWrite(Ladder_4, 0);
  digitalWrite(Ladder_5, 1);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 0);
}

void SetCurrent_150() {
  digitalWrite(Ladder_0, 1);
  digitalWrite(Ladder_1, 0);
  digitalWrite(Ladder_2, 0);
  digitalWrite(Ladder_3, 1);
  digitalWrite(Ladder_4, 0);
  digitalWrite(Ladder_5, 1);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 0);
}

void SetCurrent_200() {
  digitalWrite(Ladder_0, 1);
  digitalWrite(Ladder_1, 1);
  digitalWrite(Ladder_2, 0);
  digitalWrite(Ladder_3, 1);
  digitalWrite(Ladder_4, 0);
  digitalWrite(Ladder_5, 1);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 0);
}

void SetCurrent_250() {
  digitalWrite(Ladder_0, 0);
  digitalWrite(Ladder_1, 0);
  digitalWrite(Ladder_2, 1);
  digitalWrite(Ladder_3, 1);
  digitalWrite(Ladder_4, 0);
  digitalWrite(Ladder_5, 1);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 0);
}

void SetCurrent_300() {
  digitalWrite(Ladder_0, 0);
  digitalWrite(Ladder_1, 1);
  digitalWrite(Ladder_2, 1);
  digitalWrite(Ladder_3, 1);
  digitalWrite(Ladder_4, 0);
  digitalWrite(Ladder_5, 1);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 0);
}

void SetCurrent_350() {
  digitalWrite(Ladder_0, 1);
  digitalWrite(Ladder_1, 1);
  digitalWrite(Ladder_2, 1);
  digitalWrite(Ladder_3, 1);
  digitalWrite(Ladder_4, 0);
  digitalWrite(Ladder_5, 1);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 0);
}

void SetCurrent_400() {
  digitalWrite(Ladder_0, 1);
  digitalWrite(Ladder_1, 0);
  digitalWrite(Ladder_2, 0);
  digitalWrite(Ladder_3, 0);
  digitalWrite(Ladder_4, 1);
  digitalWrite(Ladder_5, 1);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 0);
}

void SetCurrent_450() {
  digitalWrite(Ladder_0, 0);
  digitalWrite(Ladder_1, 1);
  digitalWrite(Ladder_2, 0);
  digitalWrite(Ladder_3, 0);
  digitalWrite(Ladder_4, 1);
  digitalWrite(Ladder_5, 1);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 0);
}

void SetCurrent_500() {
  digitalWrite(Ladder_0, 1);
  digitalWrite(Ladder_1, 1);
  digitalWrite(Ladder_2, 0);
  digitalWrite(Ladder_3, 0);
  digitalWrite(Ladder_4, 1);
  digitalWrite(Ladder_5, 1);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 0);
}

void SetCurrent_550() {
  digitalWrite(Ladder_0, 1);
  digitalWrite(Ladder_1, 0);
  digitalWrite(Ladder_2, 1);
  digitalWrite(Ladder_3, 0);
  digitalWrite(Ladder_4, 1);
  digitalWrite(Ladder_5, 1);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 0);
}

void SetCurrent_600() {
  digitalWrite(Ladder_0, 0);
  digitalWrite(Ladder_1, 1);
  digitalWrite(Ladder_2, 1);
  digitalWrite(Ladder_3, 0);
  digitalWrite(Ladder_4, 1);
  digitalWrite(Ladder_5, 1);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 0);
}

void SetCurrent_650() {
  digitalWrite(Ladder_0, 1);
  digitalWrite(Ladder_1, 1);
  digitalWrite(Ladder_2, 1);
  digitalWrite(Ladder_3, 0);
  digitalWrite(Ladder_4, 1);
  digitalWrite(Ladder_5, 1);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 0);
}
