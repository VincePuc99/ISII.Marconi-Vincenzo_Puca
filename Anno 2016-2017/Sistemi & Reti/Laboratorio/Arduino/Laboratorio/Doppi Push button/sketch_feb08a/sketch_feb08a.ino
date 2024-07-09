
// INTRODUZIONE AL LINGUAGGIO C

// Definione variabili globali
 
int sw1;
int sw2;
int lamp;

int accesa;
int premuto;

// Metodi di default di Arduino
void setup()
{
   sw1=3;  // Collegato al pin digitale 3
   sw2=2;  // Collegato al pin digitale 2
   lamp=9;  // Lampada collegata al pin digitale 10
  
   pinMode(sw1, INPUT); 
   pinMode(sw2, INPUT); 
   pinMode(lamp, OUTPUT); 
  
  digitalWrite(lamp,LOW);
  
  accesa=0;  // Lampada spenta
  premuto=0;
}

void loop()
{
  // Rilevo la variazione dei pulsanti 
  while (digitalRead(sw1)==HIGH)
    premuto=1;
  
  if (premuto==1)
  {
      premuto=0;
      accesa=1-accesa;
  }
 
  if (digitalRead(sw2)==HIGH)
    accesa=1-accesa;
  
  // Controllo la lampada
  
  if (accesa==1)
  {
    // Accendo lampada
     digitalWrite(lamp,HIGH);
  }
  else
  {
    // Spengo lampada
    digitalWrite(lamp,LOW);
  }  
}
  
  
  
