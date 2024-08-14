void ParseCommands(char target) {
  if (target == CONTROL_RESET_BOARD)  //A>
  {
    Serial.end();
    asm ("jmp (0x0000)");
  }

  if (target == CONTROL_ROUTINE_RESTART)  //B>
  {
    PulseCounter = 0;
    IsWaiting = true;
    Serial.println(F("<CanRestart>"));
  }

  if (target == CONTROL_ROUTINE_START)  //C>
  {
    if (!IsRunning)
    {
      IsRunning = true;
      Serial.println(F("<StartingRoutine>"));
    }
  }

  if (target == CONTROL_ROUTINE_STOP)  //D>
  {
    if (IsRunning)
    {
      IsRunning = false;
      Serial.println(F("<StoppingRoutine>"));
    }
  }

  if (target == CONTROL_READ_START)  //E>
  {
    if (!IsRunning && !ArrayIsFull) {
      IsReading = true;
      Serial.println(F("<ReadEnabled>"));
    }
  }

  if (target == CONTROL_READ_STOP)  //F>
  {
    if (!IsRunning && IsReading) {
      IsReading = false;

      Serial.println(F("<ReadDisabled>"));

      Serial.print(F("SavedData:"));
      Serial.println(ArrayCounter);

      ParsePulseFromArray();
    }
  }

  if (target == CONTROL_MODE_PERIODIC)  //G>
  {
    PeriodicMode = !PeriodicMode;
    PulseCounter = 0;

    if (PeriodicMode) Serial.println(F("<PeriodicModeOn>"));
    else Serial.println(F("<PeriodicModeOff>"));
  }

  if (target == CONTROL_MODE_TEST)  //H>
  {
    IsTest = !IsTest;
    if (IsTest) Serial.println(F("<TestOn>"));
    else Serial.println(F("<TestOff>"));
  }
}
