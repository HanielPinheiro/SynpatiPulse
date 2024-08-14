void VerifySerial()
{
  if (millis() - verifySerial >= 50)
  {
    verifySerial = millis();
    static boolean recvInProgress = false;
    static int index = 0;
    char startMarker = '<';
    char endMarker = '>';
    char readedChar;

    while (Serial.available() > 0 && newData == false) {
      readedChar = Serial.read();
      
      if (recvInProgress == true) {
        
        if (readedChar != endMarker) {
          tempData[index] = readedChar;
          index++;
          
          if (index >= bufferSize) index = bufferSize - 1;          
        }
        else {
          tempData[index] = '\0'; // terminate the string
          recvInProgress = false;
          counterBuffer = index;
          index = 0;
          newData = true;
        }
        
      }
      else if (readedChar == startMarker) recvInProgress = true;
      
    }

    if (newData == true) {
      Serial.print(F("ReceivedData:")); Serial.println(tempData);
      
      if (counterBuffer == 1) ParseCommands(tempData[0]);

      if (counterBuffer > 1) {
        if (IsReading)
        {
          if (!ArrayIsFull)
          {
            if (ArrayCounter < numOfPulses)
            {
              memcpy(&ArrayWithPulses[ArrayCounter][0], tempData, counterBuffer);
              ArrayCounter++;

              if (ArrayCounter == numOfPulses) ArrayIsFull = true;
            }

          }
          else Serial.println(F("<ArrayFull>"));
        }

        if (IsRunning) {
          Serial.print(F("<Add> "));
          memcpy(&ArrayWithPulses[ParsedCounter][0], tempData, counterBuffer);
          Serial.println(ArrayWithPulses[ParsedCounter]);
          ParsedCounter++;
        }
      }

      newData = false;
    }
  }
}
