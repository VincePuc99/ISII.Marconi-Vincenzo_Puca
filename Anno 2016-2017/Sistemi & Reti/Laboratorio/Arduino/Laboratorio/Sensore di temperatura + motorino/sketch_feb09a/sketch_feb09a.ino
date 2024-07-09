#include "pitches.h"
int push,lasciapassare;
int pinbuzzer;

int melody[] = {
  NOTE_C4, NOTE_G3, NOTE_G3, NOTE_A3, NOTE_G3, 0, NOTE_B3, NOTE_C4
  };
  
int noteDurations[] = {
  4, 8, 8, 4, 4, 4, 4, 4
  };

void setup()
{
  pinbuzzer=8;
  lasciapassare=5;
  push=3;
  pinMode(push,INPUT);
  pinMode(pinbuzzer,OUTPUT);
  pinMode(lasciapassare,OUTPUT); 
}
void loop()
{
   if(digitalRead(push) == HIGH)
   {
    digitalWrite(lasciapassare,HIGH);  
    
    digitalWrite(pinbuzzer,HIGH);    
    buzzer();
    digitalWrite(pinbuzzer,LOW);    
    
    for(;;)
    {   
     if(digitalRead(push) == HIGH){ goto fine;}
    }  
     
   }
   else{ fine: digitalWrite(lasciapassare,LOW); }  
   delay(1000);
}

void buzzer()
{
  for (int thisNote = 0; thisNote < 8; thisNote++)
  {
    int noteDuration = 1000 / noteDurations[thisNote];
    tone(8, melody[thisNote], noteDuration);

    int pauseBetweenNotes = noteDuration * 1.30;
    delay(pauseBetweenNotes);
    
    noTone(8);
  }
}

