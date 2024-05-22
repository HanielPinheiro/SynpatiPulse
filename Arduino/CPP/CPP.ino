#define INSTRUCTION_POLARITY_P "+"
#define INSTRUCTION_UNITY_MS 77
#define INSTRUCTION_UNITY_US 85
#define INSTRUCTION_UNITY_S 83
#define INSTRUCTION_DECIMAL '.'
#define INSTRUCTION_SEPARATOR "$"
#define INSTRUCTION_END '>'

#define CONTROL_START_ROUTINE 'J'
#define CONTROL_STOP_ROUTINE 'K'
#define CONTROL_READ_INSTRUCTIONS 'L'
#define CONTROL_STOP_READ_INSTRUCTIONS 'M'
#define CONTROL_RESET_INSTRUCTION 'R'
#define CONTROL_RESET_BOARD 'D'

#define INSTRUCTION_POLARITY_P "+"
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

// =========================================================
int pulseCounter = 0;
const int numOfPulses = 50;

int Digipot_CurrentValue = 0;

int Currents[numOfPulses];                          // listed currents above
int Polarities[numOfPulses];                        //+1 or -1

int PulseLengths[numOfPulses];                   //time of pulse length
int PulseLengthsFractional[numOfPulses];                   //frac part of time of pulse length
int PulseLengthsMeasure[numOfPulses];               //time of pulse length

int InterpulseLengths[numOfPulses];              //time of interpulse interval
int InterpulseLengthsFractional[numOfPulses];              //frac part of time of interpulse interval
int InterpulseLengthsMeasure[numOfPulses];          //time of interpulse interval

bool HasInstruction = false;
bool IsReading = false;
bool IsRunning = false;

// =========================================================
const int bufferSize = 30;
int counterBuffer = 0;
char tempData[bufferSize];
const char newLine = '\n';
