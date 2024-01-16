using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager: 
  MonoBehaviour{
    public ball b;
    public paddle p;

    public static v topRight;
    public static v bottomLeft;
  }

void Start(){
  //Ball created
  Instantiate (b);
  
  //Two paddles created on both sides
  paddle p1 = Instantiate (p) as paddle;
  paddle p2 = Instantiate (p) as paddle;
  p1.Init(true);  //paddle one
  p2.Init(false);  //paddle two

  bottomLeft = Camera.main.ScreenToWorldPoint(new v(0, 0));    //converting screen pixel into game coordinates
  topRight = Camera.main.ScreenToWorldPoint(new v(Screen.width, Screen.height));
}

void Update(){
  
}
