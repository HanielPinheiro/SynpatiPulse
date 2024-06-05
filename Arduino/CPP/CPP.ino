#define CONTROL_RESET_BOARD 'A'
#define CONTROL_RESET_INSTRUCTION 'B'
#define CONTROL_ROUTINE_START 'C'
#define CONTROL_ROUTINE_STOP 'D'
#define CONTROL_READ_START 'E'
#define CONTROL_READ_STOP 'F'
#define CONTROL_MODE_PERIODIC 'G'
#define CONTROL_MODE_PULSETRAINS 'H'

#define INSTRUCTION_SET "SET"
#define INSTRUCTION_PT "PT"
#define INSTRUCTION_UNITY_MS 77
#define INSTRUCTION_UNITY_US 85
#define INSTRUCTION_UNITY_S 83
#define INSTRUCTION_DECIMAL '.'
#define INSTRUCTION_SEPARATOR '$'
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
#define numPulseTrains 4

// =========================================================

bool HasInstruction = false;
bool IsReading = false;
bool IsRunning = false;
bool IsWaiting = false;
bool NeedToParse = false;
bool PulseTrainArrayIsFull = false;

// =========================================================
int PulseCounter = 0;
bool PulseMode = false;

char PulseCurrents[numOfPulses];
int PulsePolarities[numOfPulses];

int PulseLengthsIntegerPart[numOfPulses];
int PulseLengthsFractionalPart[numOfPulses];
int PulseLengthsMeasureUnity[numOfPulses];

int InterpulseLengthsIntegerPart[numOfPulses];
int InterpulseLengthsFractionalPart[numOfPulses];
int InterpulseLengthsMeasureUnity[numOfPulses];

// =========================================================

char PulseTrains[numPulseTrains][numOfPulses];
bool PulseTrainMode = false;
int PulseTrainCounter = 0;
int PulseTrainInterval = 0;

// =========================================================

const int bufferSize = 30;
int counterBuffer = 0;
char tempData[bufferSize];
const char newLine = '\n';
