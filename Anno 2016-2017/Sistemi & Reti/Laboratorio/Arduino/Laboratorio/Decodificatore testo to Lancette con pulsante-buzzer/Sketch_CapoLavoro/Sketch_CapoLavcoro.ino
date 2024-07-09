
#include <Servo.h>
Servo motorola;
const int pinmotorola=4;
char carattere;

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
  
  motorola.attach(pinmotorola);
  Serial.begin(9600);
  motorola.write(0);
}

void loop() {
   if(digitalRead(push) == HIGH)
   {
    digitalWrite(lasciapassare,HIGH);  
    
    digitalWrite(pinbuzzer,HIGH);    
    buzzer();  
    digitalWrite(pinbuzzer,LOW);
    
    
     
     for(;;)
    {  
     carattere=Serial.read();
     switch(carattere)
    {
    case 'a':
        motorola.write(5);
        tone(8,NOTE_CS5);
        suono();
        break;
    case 'b':
        motorola.write(12);
        tone(8,NOTE_A6);
        suono();
        break;
    case 'c':
        motorola.write(19);
        tone(8,NOTE_B3);
        suono();
        break;
    case 'd':
        motorola.write(26);
        tone(8,NOTE_A5);
        suono();
        break;
    case 'e':
        motorola.write(32);
        tone(8,NOTE_F4);
        suono();
        break;
    case 'f':
        motorola.write(38);
        tone(8,NOTE_C2);
        suono();
        break;
    case 'g':
        motorola.write(45);
        tone(8,NOTE_C4);
        suono();
        break;
    case 'h':
        motorola.write(51);
        tone(8,NOTE_A6);
        suono();
        break;
    case 'i':
        motorola.write(59);
        tone(8,NOTE_E6);
        suono();
        break;    
    case 'l':
        motorola.write(65);
        tone(8,NOTE_B4);
        suono();
        break;
    case 'm':
        motorola.write(70);
        tone(8,NOTE_E7);
        suono();
        break;
    case 'n':
        motorola.write(75);
        tone(8,NOTE_B1);
        suono();
        break;
    case 'o':
        motorola.write(80);
        tone(8,NOTE_A1);
        suono();
        break;
    case 'p':
        motorola.write(86);
        tone(8,NOTE_F4);
        suono();
        break;
    case 'q':
        motorola.write(92);
        tone(8,NOTE_C2);
        suono();
        break;
    case 'r':
        motorola.write(100);
        tone(8,NOTE_B7);
        suono();
        break;
    case 's':
        motorola.write(108);
        tone(8,NOTE_GS3);
        suono();
        break;
    case 't':
        motorola.write(115);
        tone(8,NOTE_DS5);
        suono();
        break;
    case 'u':
        motorola.write(121);
        tone(8,NOTE_CS8);
        suono();
        break;
    case 'v':
        motorola.write(128);
        tone(8,NOTE_B0);
        suono();
        break;
    case 'z':
        motorola.write(136);
        tone(8,NOTE_DS4);
        suono();
        break;
    default:
        motorola.write(0);
        break;
  }
  Serial.println(carattere);
  delay(1500);   
  
     if(digitalRead(push) == HIGH){ goto fine;}//if fine
    } //fine for    
   }
   else{ fine: digitalWrite(lasciapassare,LOW);}  
   delay(500);
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

void suono()
{
  delay(500);
  noTone(8);
}

