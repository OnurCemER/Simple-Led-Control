#define ledKirmizi 5
#define ledYesil 2
#define ledSari 3
#define ledMavi 4


void setup() {
  pinMode(ledKirmizi,OUTPUT);
  pinMode(ledYesil,OUTPUT);  
  pinMode(ledMavi,OUTPUT);  
  pinMode(ledSari,OUTPUT);  
  Serial.begin(9600);
}

void loop() {
  if(Serial.available())
 {
  char gelenBilgi=Serial.read();
  if(gelenBilgi=='1'){digitalWrite(ledKirmizi,HIGH);}
  else if(gelenBilgi=='2'){digitalWrite(ledKirmizi,LOW);}
  else if(gelenBilgi=='3'){digitalWrite(ledYesil,HIGH);}
  else if(gelenBilgi=='4'){digitalWrite(ledYesil,LOW);}
  else if(gelenBilgi=='5'){digitalWrite(ledMavi,HIGH);}
  else if(gelenBilgi=='6'){digitalWrite(ledMavi,LOW);}
  else if(gelenBilgi=='7'){digitalWrite(ledSari,HIGH);}
  else if(gelenBilgi=='8'){digitalWrite(ledSari,LOW);}
  else if(gelenBilgi=='9')
  {
    digitalWrite(ledKirmizi,HIGH);
    digitalWrite(ledYesil,HIGH);
    digitalWrite(ledMavi,HIGH);
    digitalWrite(ledSari,HIGH);
  }
  else if(gelenBilgi=='0')
  {
    digitalWrite(ledKirmizi,LOW);
    digitalWrite(ledYesil,LOW);
    digitalWrite(ledMavi,LOW);
    digitalWrite(ledSari,LOW);
  }
  delay(100);
 }
  
}
