#define F_CPU 16000000

#define CONTROL_START_ROUTINE 'J'
#define CONTROL_STOP_ROUTINE 'K'
#define CONTROL_READ_INSTRUCTIONS 'L'
#define CONTROL_STOP_READ_INSTRUCTIONS 'M'
#define CONTROL_RESET_INSTRUCTION 'R'
#define CONTROL_RESET_BOARD 'D'

#define INSTRUCTION_SET "SET"
#define INSTRUCTION_POLARITY_P "+"
#define INSTRUCTION_UNITY_MS 77
#define INSTRUCTION_UNITY_US 85
#define INSTRUCTION_UNITY_S 83
#define INSTRUCTION_DECIMAL '.'
#define INSTRUCTION_COMMA_SEPARATOR ","
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

// =========================================================
int pulseCounter = 0;
const int numOfPulses = 10;

int PulseCurrents[numOfPulses];
int PulsePolarities[numOfPulses]; //(Positive or Negative)

int PulseLengthsIntegerPart[numOfPulses];
int PulseLengthsFractionalPart[numOfPulses];
int PulseLengthsMeasureUnity[numOfPulses];

int InterpulseLengthsIntegerPart[numOfPulses];
int InterpulseLengthsFractionalPart[numOfPulses];
int InterpulseLengthsMeasureUnity[numOfPulses];

// =========================================================
const int numPulseTrains = 199;
float LorenzPulseTrainValues[numPulseTrains];

int LorenzCounter = 0;
int LorenzBatteryInterval = 0;
int LorenzBatteryCounter = 0;
int LorenzPreviousPolarity = 1;
int LorenzMode = 0;

bool HasInstruction = false;
bool IsReading = false;
bool IsRunning = false;

// =========================================================
const int bufferSize = 30;
int counterBuffer = 0;
char tempData[bufferSize];
const char newLine = '\n';
