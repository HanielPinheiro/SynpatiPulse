void setup() {
  pinMode(Ladder_0, OUTPUT);
  pinMode(Ladder_1, OUTPUT);
  pinMode(Ladder_2, OUTPUT);
  pinMode(Ladder_3, OUTPUT);
  pinMode(Ladder_4, OUTPUT);
  pinMode(Ladder_5, OUTPUT);
  pinMode(Ladder_6, OUTPUT);
  pinMode(Ladder_7, OUTPUT);

  pinMode(CLOCK_1_PIN, OUTPUT);
  pinMode(CLOCK_2_PIN, OUTPUT);
  
  digitalWrite(CLOCK_1_PIN, HIGH);
  digitalWrite(CLOCK_2_PIN, LOW);
  SetCurrent_0();
  
  Serial.begin(115200);
  Serial.println(F("<Ready>"));
}

void loop()
{
  if(IsTest) TestRoutine();
  else if (IsRunning)
  {
    if (PeriodicMode) PeriodicRoutine();
    else NonPeriodicRoutine();
  }
    
  VerifySerial();
}
