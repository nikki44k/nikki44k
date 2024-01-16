using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager: 
  behaviour{
    public ball b;
    public paddle p;
  }

void start(){
  //Ball created
  Instantiate (b);
  
  //Two paddles created on both sides
  paddle p1 = Instantiate (p) as paddle;
  paddle p2 = Instantiate (p) as paddle;
  p1.Init(true);  //paddle one
  p2.Init(false);  //paddle two
}
void update(){
  
}
