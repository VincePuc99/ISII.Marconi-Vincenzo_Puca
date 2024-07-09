const int pinfoto = 3;
const int pinled = 8;

int valore;

void setup()
{
  
  pinMode(pinfoto,INPUT);
  pinMode(pinled,OUTPUT);
  
}

void loop()
{
  valore = digitalRead(pinfoto);
  
  if(valore == HIGH) {digitalWrite(pinled,HIGH);}
  else{ digitalWrite(pinled,LOW);}
  
  delay(1000);
}
