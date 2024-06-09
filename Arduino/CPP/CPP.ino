  #define CONTROL_RESET_BOARD 'A'
#define CONTROL_RESET_INSTRUCTION 'B'
#define CONTROL_ROUTINE_START 'C'
#define CONTROL_ROUTINE_STOP 'D'
#define CONTROL_READ_START 'E'
#define CONTROL_READ_STOP 'F'
#define CONTROL_MODE_PERIODIC 'G'
#define CONTROL_MODE_PULSETRAINS 'H'

#define INSTRUCTION_SET "SET"
#define INSTRUCTION_UNITY_MS 77
#define INSTRUCTION_UNITY_US 85
#define INSTRUCTION_UNITY_S 83
#define INSTRUCTION_DECIMAL '.'
#define INSTRUCTION_SEPARATOR "$"
#define INSTRUCTION_END '>'

#define Ladder_0 9
#define Ladder_1 8
#define Ladder_2 7
#define Ladder_3 6
#define Ladder_4 5
#define Ladder_5 4
#define Ladder_6 3
#define Ladder_7 2

#define CLOCK_1_PIN 12
#define CLOCK_2_PIN 11

#define numOfPulses 50
#define bufferSize 30

// =========================================================

boolean HasInstruction = false;
boolean IsReading = false;
boolean IsRunning = false;
boolean IsWaiting = false;
boolean NeedToParse = false;
boolean PulseTrainArrayIsFull = false;

// =========================================================
int PulseCounter = 0;
boolean PulseMode = false;
int Pulse[8] = {0};
/*
char PulseCurrents[numOfPulses]= {"NULL"};
int PulsePolarities[numOfPulses]= {"NULL"};

int PulseLengthsIntegerPart[numOfPulses]= {"NULL"};
int PulseLengthsFractionalPart[numOfPulses]= {"NULL"};
int PulseLengthsMeasureUnity[numOfPulses]= {"NULL"};

int InterpulseLengthsIntegerPart[numOfPulses]= {"NULL"};
int InterpulseLengthsFractionalPart[numOfPulses]= {"NULL"};
int InterpulseLengthsMeasureUnity[numOfPulses]= {"NULL"};*/

// =========================================================

String PulseTrains[numOfPulses] = {"NULL"};
boolean PulseTrainMode = false;
int PulseTrainCounter = 0;
int PulseTrainInterval = 0;

// =========================================================
int counterBuffer = 0;
char tempData[bufferSize];
