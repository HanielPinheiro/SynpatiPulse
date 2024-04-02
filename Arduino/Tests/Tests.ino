//#define DIGIPOT_UP   HIGH
//#define DIGIPOT_DOWN LOW
//#define DIGIPOT_MAX_AMOUNT 99
//#define DIGIPOT_UNKNOWN 255
//
//uint8_t _currentValue = 0;
//uint8_t _incPin = 8;
//uint8_t _udPin = 7;
//uint8_t _csPin = 9;
//
//uint8_t _turnOnOffPin = 5;
//
//uint8_t _vin2Pin = 11;
//uint8_t _vin1Pin = 12;
//uint8_t _ledPin = 13;
//
//void setup() {
//  Serial.begin(115200);
//  DefineDigitalPins();
//  Reset();
//
//  //delta(vh - vl) = 1k100Ohm
//  //58 = 654 → 96
//  //54 = 596
//  //51 = 556
//  //47 = 504
//  //43 = 455
//  //38 = 395
//  //34 = 346
//  //30 = 300
//  //26 = 250
//  //22 = 195
//  //19 = 155
//  //15 = 100uA
//  //11 = 51 uA
//
//  Set(8);
//  Serial.println("Stimulator is ready");
//}
//
//int val = 8;
//void loop()
//{
//  Routine3();
//}
//
//void Routine1()
//{
//  digitalWrite(_ledPin, DIGIPOT_UP);
//  digitalWrite(_vin2Pin, DIGIPOT_DOWN);
//  digitalWrite(_vin1Pin, DIGIPOT_DOWN);
//  delay(3000);
//
//  digitalWrite(_ledPin, DIGIPOT_DOWN);
//  digitalWrite(_vin2Pin, DIGIPOT_DOWN);
//  digitalWrite(_vin1Pin, DIGIPOT_UP);
//  delay(3000);
//
//  digitalWrite(_ledPin, DIGIPOT_UP);
//  delay(50);
//  digitalWrite(_ledPin, DIGIPOT_DOWN);
//  delay(50);
//  digitalWrite(_ledPin, DIGIPOT_UP);
//  digitalWrite(_vin2Pin, DIGIPOT_UP);
//  digitalWrite(_vin1Pin, DIGIPOT_UP);
//  delay(3000);
//
//  digitalWrite(_ledPin, DIGIPOT_DOWN);
//  digitalWrite(_vin2Pin, DIGIPOT_UP);
//  digitalWrite(_vin1Pin, DIGIPOT_DOWN);
//  delay(3000);
//}
//
//void Routine2()
//{
//  digitalWrite(_vin2Pin, DIGIPOT_DOWN);
//  digitalWrite(_vin1Pin, DIGIPOT_DOWN);
//  delayMicroseconds(50);
//
//  digitalWrite(_vin2Pin, DIGIPOT_DOWN);
//  digitalWrite(_vin1Pin, DIGIPOT_UP);
//  delayMicroseconds(950);
//  delay(249);
//
//  digitalWrite(_vin2Pin, DIGIPOT_UP);
//  digitalWrite(_vin1Pin, DIGIPOT_UP);
//  delayMicroseconds(50);
//
//  digitalWrite(_vin2Pin, DIGIPOT_DOWN);
//  digitalWrite(_vin1Pin, DIGIPOT_UP);
//  delayMicroseconds(950);
//  delay(249);
//}
//
//void Routine3()
//{
//  Serial.println(val);
//  Serial.println(_currentValue);
//  Set(val);
//
//  digitalWrite(_ledPin, DIGIPOT_UP);
//  delay(50);
//  digitalWrite(_ledPin, DIGIPOT_DOWN);
//  delay(50);
//  digitalWrite(_ledPin, DIGIPOT_UP);
//  digitalWrite(_vin2Pin, DIGIPOT_UP);
//  digitalWrite(_vin1Pin, DIGIPOT_UP);
//  delay(3000);
//
//  val += 10;
//  if (_currentValue >= 99) {
//    val = 8;
//    Reset();
//  }
//}
//
//
//void DefineDigitalPins() {
//  _currentValue = DIGIPOT_UNKNOWN;
//
//  pinMode(_incPin, OUTPUT);
//  pinMode(_udPin, OUTPUT);
//  pinMode(_csPin, OUTPUT);
//  digitalWrite(_csPin, DIGIPOT_UP);
//
//  pinMode(_vin2Pin, OUTPUT);
//  pinMode(_vin1Pin, OUTPUT);
//  pinMode(_ledPin, OUTPUT);
//
//  pinMode(_turnOnOffPin, OUTPUT);
//  digitalWrite(_turnOnOffPin, DIGIPOT_UP);
//}
//
//void Set(uint8_t value) {
//  value = constrain(value, 0, DIGIPOT_MAX_AMOUNT);
//
//  if (_currentValue == DIGIPOT_UNKNOWN) Reset();
//
//  if (_currentValue > value) Change(DIGIPOT_DOWN, _currentValue - value);
//
//  if (_currentValue < value) Change(DIGIPOT_UP, value - _currentValue);
//}
//
//
//
//void Reset() {
//  // change down maximum number of times to ensure the value is 0
//  Decrease(DIGIPOT_MAX_AMOUNT);
//  _currentValue = 0;
//}
//
//void Increase(uint8_t amount) {
//  Change(DIGIPOT_UP, amount);
//}
//
//void Decrease(uint8_t amount) {
//  Change(DIGIPOT_DOWN, amount);
//}
//
//void Change(uint8_t direction, uint8_t amount) {
//  amount = constrain(amount, 0, DIGIPOT_MAX_AMOUNT);
//  digitalWrite(_udPin, direction);
//  digitalWrite(_incPin, HIGH);
//  digitalWrite(_csPin, LOW);
//
//  for (uint8_t i = 0; i < amount; i++) {
//    digitalWrite(_incPin, LOW);
//    delayMicroseconds(200);
//    digitalWrite(_incPin, HIGH);
//    delayMicroseconds(200);
//    if (_currentValue != DIGIPOT_UNKNOWN) {
//      _currentValue += (direction == DIGIPOT_UP ? 1 : -1);
//      _currentValue = constrain(_currentValue, 0, DIGIPOT_MAX_AMOUNT);
//    }
//
//  }
//  digitalWrite(_csPin, HIGH);
//}
