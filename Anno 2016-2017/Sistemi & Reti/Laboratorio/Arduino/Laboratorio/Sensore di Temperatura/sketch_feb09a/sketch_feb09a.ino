const int lamp=8;
const int tmp=0;

int valore,precisione,tensione,gradotensione,gradi;

void setup()
{
  Serial.begin(9600);
   valore=0;
   pinMode(lamp,OUTPUT);
}


void loop()
{
  valore=analogRead(tmp);
  gradi=((valore*0.004882812) -0.5) / 0.01;

  Serial.println(gradi);
  
  if(gradi <=28){digitalWrite(lamp,HIGH);}
  else{digitalWrite(lamp,LOW);}

  delay(3000);
}
