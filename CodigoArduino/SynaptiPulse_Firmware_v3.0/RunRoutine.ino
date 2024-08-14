void PeriodicRoutine() {
  if (ArrayCounter == 1) RunPulse();
  else
  {
    ParsePulseFromArray();
    RunPulse();
  }
}

void NonPeriodicRoutine()
{
  if (!IsWaiting)
  {
    RunPulse();
    IsWaiting = true;

    if (!PeriodicMode && PulseCounter == ArrayCounter) {
      if (ParsedCounter == 0)
      {
        IsRunning = false;
        IsWaiting = false;
        Serial.println(F("<FimDoTremDePulsos>"));
      }
      else {
        Serial.println(F("<HasMoreData>"));
        ArrayCounter = ParsedCounter;
        PulseCounter = 0;
        ParsedCounter = 0;
      }
    }

    if (PeriodicMode && ArrayCounter == 1) IsWaiting = false;
    Serial.println(F("<Executed>"));
  }
  else {
    ParsePulseFromArray();
    Serial.println(F("<Parsed>"));
    IsWaiting = false;
  }
}
