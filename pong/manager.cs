using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour{
    public ball b;
    public paddle p;

    public static Vector2 bottomLeft;
    public static Vector2 topRight;

    // Start is called before the first frame update
    void Start(){

        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));    //converting screen pixel into game coordinates
        topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        //Ball created
        Instantiate(b);

        //Two paddles created on both sides
        paddle p1 = Instantiate(p) as paddle;
        paddle p2 = Instantiate(p) as paddle;
        p1.Init(true);  //paddle one
        p2.Init(false);  //paddle two

        
    }

    // Update is called once per frame
    void Update(){

    }
}
