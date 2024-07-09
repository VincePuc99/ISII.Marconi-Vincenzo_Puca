const int lamp=10;
const int tmp=0;

int valore,precisione,tensione,gradotensione,gradi;

void setup()
{
  valore=0;
   pinMode(lamp,OUTPUT);
}


void loop()
{
  valore=analogRead(tmp);
  gradi=map(valore,20,358,-40,125);
  
  if(gradi<19 && gradi >=16){digitalWrite(lamp,HIGH);}
  else{digitalWrite(lamp,LOW);}

}
