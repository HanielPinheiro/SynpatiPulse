#include "headers/config.h"
#include "headers/RoutinesDeclarations.h"

extern uint8_t PulseCounter;

extern uint8_t PulsePolarities[numOfPulses];
extern uint8_t PulseLengthsMeasureUnity[numOfPulses];
extern uint8_t InterpulseLengthsMeasureUnity[numOfPulses];
extern uint8_t PulseCurrents[numOfPulses];

extern uint16_t PulseLengthsIntegerPart[numOfPulses];
extern uint16_t PulseLengthsFractionalPart[numOfPulses];
extern uint16_t InterpulseLengthsIntegerPart[numOfPulses];
extern uint16_t InterpulseLengthsFractionalPart[numOfPulses];

extern char jumpline[];

extern uint8_t DebugMode;

void ParsePulse(uint8_t* data, uint8_t size)
{
	uint8_t block = 0;
	uint8_t tempCounter = 0;
	uint8_t tempData[numOfPulses] = {0};
	
	if(DebugMode)
	{
		data = (uint8_t*) "SET$150$1$200.09U$999.808M";
		size = 26;
	}
	
	
	for(uint8_t i = 0; i< size; i++){
		if(data[i] != INSTRUCTION_SEPARATOR)
		{
			tempData[tempCounter] = data[i];
			tempCounter++;
		}
		else
		{
			if(block == 0){ if(strcmp((const char *)tempData, INSTRUCTION_SET) != 0) break; }
			else if(block == 1)
			{
				if(DebugMode) UartSendArray((uint8_t *)"Block = 1\n\r");
				SetCurrentValueToArr((char*) tempData);
			}
			else if(block == 2 && tempCounter == 1)
			{
				PulsePolarities[PulseCounter] = tempData[0];
				
				UartSendArray((uint8_t *)"Pulse Polarity: ");
				UartSendByte(PulsePolarities[PulseCounter]);
				UartSendString(jumpline);
			}
			else if(block == 3)
			{
				if(DebugMode) UartSendArray((uint8_t *)"Block = 3\n\r");
				GetTimeFromInstruction(tempData, tempCounter, PulseLengthsIntegerPart, PulseLengthsFractionalPart, PulseLengthsMeasureUnity);
			}
			
			block++;
			memset(tempData, 0, numOfPulses);
			tempCounter = 0;
		}
	}
	
	if(block == 4)
	{
		if(DebugMode) UartSendArray((uint8_t *) "Block = 4\n\r");
		GetTimeFromInstruction(tempData, tempCounter, InterpulseLengthsIntegerPart, InterpulseLengthsFractionalPart, InterpulseLengthsMeasureUnity);
		UartSendArray((uint8_t *)"Parsed: ");
		PulseCounter++;
		if(PulseCounter == 10) UartSendArray((uint8_t *)"10");
		else UartSendChar((char) (PulseCounter + 48));
		UartSendString(jumpline);
	}
}

void GetTimeFromInstruction(uint8_t *data, uint8_t size, uint16_t* lengths, uint16_t* fracs, uint8_t* measures)
{
	uint8_t timeCounter = 0;
	uint8_t timeArr[numOfPulses] = {0};
	uint8_t hasFraction = 0;
	
	if(DebugMode) UartSendArray((uint8_t *) "TimeParse\n\r");
	
	for (uint8_t i = 0; i < size; i++){
		
		if (data[i] == INSTRUCTION_UNITY_MS || data[i] == INSTRUCTION_UNITY_US || data[i] == INSTRUCTION_UNITY_S)
		{
			if(DebugMode)
			{
				UartSendArray((uint8_t *) "Step A\n\r");
				UartSendByte(data[i]);
				UartSendString(jumpline);
			}
			
			measures[PulseCounter] = data[i];
			
			if(hasFraction) //Example: 200.85M → timeArr = 85
			{
				if(DebugMode)
				{
					UartSendArray((uint8_t *) "Step B\n\r");
					UartSendArray(timeArr);
					UartSendString(jumpline);
				}
				
				if(timeCounter < 3) {
					for(uint8_t i =0; i< 3-timeCounter; i++)
					timeArr[timeCounter + i] = 48;
				}
				
				fracs[PulseCounter] = convertFrom8ArrTo16(timeArr);
				memset(timeArr, 0, numOfPulses);
				timeCounter= 0;
				hasFraction = 0;
			}
			else { //Example: 200U
				if(DebugMode)
				{
					UartSendArray((uint8_t *) "Step C\n\r");
					UartSendArray(timeArr);
					UartSendString(jumpline);
				}
				lengths[PulseCounter] = convertFrom8ArrTo16(timeArr);
				fracs[PulseCounter] = 0;
			}
		}
		else if(data[i] == INSTRUCTION_DECIMAL) //Example 200.85M → timeArr = 200
		{
			if(DebugMode)
			{
				UartSendArray((uint8_t *) "Step D\n\r");
				UartSendArray(timeArr);
				UartSendString(jumpline);
			}
			lengths[PulseCounter] = convertFrom8ArrTo16(timeArr);
			memset(timeArr, 0, numOfPulses);
			timeCounter= 0;
			hasFraction = 1;
			
		}
		else
		{
			timeArr[timeCounter] = data[i];
			timeCounter++;
		}
	}
	
	char a[] = "Data: ";
	char b[] = "Integer: ";
	char c[] = "Frac: ";
	char d[] = "Measure: ";
	
	UartSendString(a);
	UartSendArray(data);
	UartSendString(jumpline);
	
	UartSendString(b);
	UartSend16Bit(lengths[PulseCounter]);
	UartSendString(jumpline);
	
	UartSendString(c);
	UartSend16Bit(fracs[PulseCounter]);
	UartSendString(jumpline);
	
	UartSendString(d);
	UartSend16Bit(measures[PulseCounter]);
	UartSendString(jumpline);
}

void SetCurrentValueToArr(char* nomCurr)
{
	UartSendArray((uint8_t *)"Current: ");
	uint8_t v[2]={0};
	if (strcmp(nomCurr, "50") == 0) 	{
		PulseCurrents[PulseCounter] = 0;
		UartSendByte(48);
	}
	else if   (strcmp(nomCurr, "100") == 0){
		PulseCurrents[PulseCounter] = 1;
		UartSendByte(49);
	}
	else if   (strcmp(nomCurr, "150") == 0){
		PulseCurrents[PulseCounter] = 2;
		UartSendByte(50);
	}
	else if   (strcmp(nomCurr, "200") == 0){
		PulseCurrents[PulseCounter] = 3;
		UartSendByte(51);
	}
	else if   (strcmp(nomCurr, "250") == 0){
		PulseCurrents[PulseCounter] = 4;
		UartSendByte(52);
	}
	else if   (strcmp(nomCurr, "300") == 0){
		PulseCurrents[PulseCounter] = 5;
		UartSendByte(53);
	}
	else if   (strcmp(nomCurr, "350") == 0){
		PulseCurrents[PulseCounter] = 6;
		UartSendByte(54);
	}
	else if   (strcmp(nomCurr, "400") == 0){
		PulseCurrents[PulseCounter] = 7;
		UartSendByte(55);
	}
	else if   (strcmp(nomCurr, "450") == 0){
		PulseCurrents[PulseCounter] = 8;
		UartSendByte(56);
	}
	else if   (strcmp(nomCurr, "500") == 0){
		PulseCurrents[PulseCounter] = 9;
		UartSendByte(57);
	}
	else if   (strcmp(nomCurr, "550") == 0){
		PulseCurrents[PulseCounter] = 10;
		v[0] = 49;
		v[1] = 48;
		UartSendArray(v);
	}
	else if   (strcmp(nomCurr, "600") == 0){
		PulseCurrents[PulseCounter] = 11;
		v[0] = 49;
		v[1] = 49;
		UartSendArray(v);
	}
	else {
		PulseCurrents[PulseCounter] = 12;
		v[0] = 49;
		v[1] = 50;
		UartSendArray(v);
	}
	UartSendArray((uint8_t*)" - ");
	UartSendString(nomCurr);
	UartSendString(jumpline);
}

void ParsePulseTrain(uint8_t* data[]) {
	uint8_t siz =0;
	for (uint8_t i = 0; i < PulseCounter; i++)
	{
		siz = arr_length(data[i]);
		ParsePulse(data[i], siz);
	}
}
