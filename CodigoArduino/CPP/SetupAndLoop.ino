//ISR + nome da interrupção
ISR(TIMER1_OVF_vect) {
  if (IsWaiting) {
    ParsePulseFromArray();
    IsWaiting = false;
  }
}


void setup() {
  /*
   * In clear timer on compare or CTC mode (WGM02:0 = 2), the OCR0A register is used to manipulate the counter resolution. 
   * In CTC mode the counter is cleared to zero when the counter value (TCNT0) matches the OCR0A. The OCR0A defines the top 
   * value for the counter, hence also its resolution. This mode allows greater control of the compare match output frequency. 
   * It also simplifies the operation of counting external events.
   * For generating a waveform output in CTC mode, the OC0A output can be set to toggle its logical level on each compare match 
   * by setting the compare output mode bits to toggle mode (COM0A1:0 = 1). The OC0A value will not be visible on the port pin 
   * unless the data direction for the pin is set to output. The waveform generated will have a maximum frequency of 
   * fOC0 = fclk_I/O/2 when OCR0A is set to zero (0x00).
   */
  cli(); // timer 1 tem 16bits, ou seja conta de 0 a 65536  
  /*//Eu
  TCCR1A = 0b01000000; // WGM11 E WGM10 em 0; COM1A0 → 1
  TCCR1B = 0b00001001; //Prescaler de 1, WGM12 = 1 → CTC Mode
  OCR1A = 0x01;
  TIMSK1 = 0b00000001; //Interrupção por overflow do timer 1*/
  // Timer 1 configuration - ChatGPT
  TCCR1A = 0b00000000; // WGM11 = 0, WGM10 = 0 for CTC mode
  TCCR1B = 0b00001011; // WGM12 = 1 for CTC mode, Prescaler of 64 (CS11 = 1, CS10 = 1)
  OCR1A = 249; // Set compare match value to 249 for 1 ms interrupts
  TIMSK1 = 0b00000010; // Enable Timer 1 compare match A interrupt
  sei();
  
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
  StopPulses();

  Serial.begin(115200);
  Serial.write("<Ready>");
}

void StopPulses() {
  digitalWrite(CLOCK_1_PIN, LOW);
  digitalWrite(CLOCK_2_PIN, HIGH);
  SetCurrent_0();
}



void loop() //<SET$100$1$100.050M$400.108U><SET$350$0$322.655M$123.456U><SET$450$1$789.012M$345.678U>
{
  if (IsRunning && !IsWaiting) RunRoutine();

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
          if (index >= bufferSize) {
            index = bufferSize - 1;
          }
        }
        else {
          tempData[index] = '\0'; // terminate the string
          recvInProgress = false;
          counterBuffer = index;
          index = 0;
          newData = true;
        }
      }
      else if (readedChar == startMarker) {
        recvInProgress = true;
      }
    }

    if (newData == true) {
      Serial.write("ReceivedData:"); Serial.write(tempData);

      if (counterBuffer == 1) ParseCommands(tempData[0]);

      if (counterBuffer > 1 && IsReading) {
        if (!ArrayIsFull)
        {
          if (ArrayCounter < numOfPulses)
          {
            ArrayWithPulses[ArrayCounter] = tempData;
            ArrayCounter++;
            if (ArrayCounter == numOfPulses) ArrayIsFull = true;
          }
        }  else Serial.write("<ArrayFull>");
      }

      newData = false;
    }
  }
}
