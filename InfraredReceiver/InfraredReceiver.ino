/**
 * Serial infrared receiver module
 * @author Victor M. Batlle <victor.martinez.batlle@gmail.com>
 */

#include <IRremote.h>

int RECV_PIN = 2; // set this to the pin connected to the ir receiver

IRrecv irrecv(RECV_PIN);
decode_results results;

void setup()
{
  
  Serial.begin(9600);
  irrecv.enableIRIn(); // Start the receiver
}

void loop() {
  if (irrecv.decode(&results)) {
  	if (results.value != 0xFFFFFFFF){	
	    Serial.print(results.value, HEX);
  	}
  	irrecv.resume(); // Receive the next value
  }
}
