void ParseCommands(char target) {
  if (target == CONTROL_RESET_BOARD)  //A>
  {
    Serial.end();
    asm ("jmp (0x0000)");
  }

  if (target == CONTROL_RESET_INSTRUCTION)  //B>
  {
    StopPulses();
    IsReading = false;
    IsRunning = false;
    IsWaiting = false;  
    PulseCounter = 0;

    Serial.write("<Reseted>");
  }

  if (target == CONTROL_ROUTINE_START)  //C>
  {
    if (!IsRunning)
    {
      IsRunning = true;
      Serial.write("<StartingRoutine>");
    }
  }

  if (target == CONTROL_ROUTINE_STOP)  //D>
  {
    if (IsRunning)
    {
      IsRunning = false;
      Serial.write("<StoppingRoutine>");
    }
  }

  if (target == CONTROL_READ_START)  //E>
  {
    if (!IsRunning && !ArrayIsFull) {
      IsReading = true;
      Serial.write("<ReadEnabled>");
    }
  }

  if (target == CONTROL_READ_STOP)  //F>
  {
    if (!IsRunning && IsReading) {
      IsReading = false;
      Serial.write("<ReadDisabled>");
      Serial.write("SavedData:");
      Serial.write(ArrayCounter);
      ParsePulseFromArray();
    }
  }
}
