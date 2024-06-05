void ParseCommands(char target) {
  if (target == CONTROL_RESET_BOARD)  //A>
  {
    Serial.end();
    asm ("jmp (0x0000)");
  }

  if (target == CONTROL_RESET_INSTRUCTION)  //B>
  {
    StopPulses();
    ResetArrays();

    HasInstruction = false;
    IsReading = false;
    IsRunning = false;
    IsWaiting = false;
    NeedToParse = false;

    PulseMode = false;
    PulseCounter = 0;
    PulseTrainMode = false;
    PulseTrainCounter = 0;
    PulseTrainInterval = 0;

    Serial_ResetBuffer();
    Serial.println("Reseted");
  }

  if (target == CONTROL_ROUTINE_START)  //C>
  {
    Serial.println("StartingRoutine");
    if (!IsReading && HasInstruction)
    {
      IsRunning = true;
      Serial.println("RoutineEnabled");
    }
  }

  if (target == CONTROL_ROUTINE_STOP)  //D>
  {
    Serial.println("StopingRoutine");
    if (IsRunning && !IsReading && HasInstruction)
    {
      IsRunning = false;
      Serial.println("RoutineDisabled");
    }
  }

  if (target == CONTROL_READ_START)  //E>
  { Serial.println("StartingRead");
    if (!IsRunning && !HasInstruction) {
      IsReading = true;
      Serial.println("ReadEnabled");
    }
  }

  if (target == CONTROL_READ_STOP)  //F>
  {
    Serial.println("StopingRead");
    if (!IsRunning && IsReading && !HasInstruction) {
      IsReading = false;
      HasInstruction = true;
      Serial.println("ReadDisabled");
      Serial.print("SavedData: "); Serial.println(PulseCounter);
    }
  }

  if (target == CONTROL_MODE_PERIODIC)  //G>
  {
    if (!IsRunning && IsReading) {
      if (HasInstruction && PulseTrainMode) Serial.println("NeedReset");
      else {
        Serial.println("PeriodicMode");
        PulseTrainMode = false;
        PulseMode = true;
      }
    }
  }

  if (target == CONTROL_MODE_PULSETRAINS) //H>
  {
    if (!IsRunning && IsReading) {
      if (HasInstruction && PulseMode) Serial.println("NeedReset");
      else {
        Serial.println("PulseTrainMode");
        PulseTrainMode = true;
        PulseMode = false;
      }
    }
  }
}

void ResetArrays()
{
  PulseCurrents[numOfPulses] = { NULL };

  PulsePolarities[numOfPulses] = { NULL };

  PulseLengthsIntegerPart[numOfPulses] = { NULL };
  PulseLengthsFractionalPart[numOfPulses] = { NULL };
  PulseLengthsMeasureUnity[numOfPulses] = { NULL };

  InterpulseLengthsIntegerPart[numOfPulses] = { NULL };
  InterpulseLengthsFractionalPart[numOfPulses] = { NULL };
  InterpulseLengthsMeasureUnity[numOfPulses] = { NULL };
}
