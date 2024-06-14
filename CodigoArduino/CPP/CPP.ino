#define CONTROL_RESET_BOARD 'A'
#define CONTROL_ROUTINE_RESTART 'B'
#define CONTROL_ROUTINE_START 'C'
#define CONTROL_ROUTINE_STOP 'D'
#define CONTROL_READ_START 'E'
#define CONTROL_READ_STOP 'F'
#define CONTROL_MODE_PERIODIC 'G'

#define INSTRUCTION_UNITY_MS 77
#define INSTRUCTION_UNITY_US 85
#define INSTRUCTION_UNITY_S 83
#define INSTRUCTION_DECIMAL '.'
#define INSTRUCTION_SEPARATOR "$"

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

#define numOfPulses 40
#define bufferSize 30

// =========================================================
//Variables to control system
boolean IsReading = false;
boolean IsRunning = false;
boolean IsWaiting = false;
boolean Restarted = false;

char ArrayWithPulses[numOfPulses][bufferSize];
int ArrayCounter = 0;
boolean ArrayIsFull = false;
boolean PeriodicMode = false;

int Pulse[8] = {0};
int PulseCounter = 0;
unsigned long int verifyDelay = 0;

int ParsedCounter = 0;
// =========================================================
//Variables about SerialCommunication
int counterBuffer = 0;
char tempData[bufferSize];
unsigned long int verifySerial = 0;
boolean newData = false;
