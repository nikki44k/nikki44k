using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    [SerializeField]
    public float speed;
    float height;
    public bool is_r;
    string input;

    void Start() { 
        height = transform.localScale.y;
    }

    public void Init(bool is_rpaddle) {
        is_r = is_rpaddle;
        Vector2 pos = Vector2.zero;
        if (is_rpaddle) {       //paddle will be on the rightside
            pos = new Vector2(NewBehaviourScript.topRight.x, 0);
            pos -= Vector2.right * transform.localScale.x;  //moves to left
            input = "RightPaddle";

        }else{    //paddle will be on the left side
            pos = new Vector2(NewBehaviourScript.bottomLeft.x, 0);
            pos += Vector2.right * transform.localScale.x;  //moves to right
            input = "LeftPaddle";
         }
            transform.position = pos;
            transform.name = input;
        }

        void Update(){
            float move = Input.GetAxis(input) * Time.deltaTime * speed;

            //Paddle movement
            if (transform.position.y < NewBehaviourScript.bottomLeft.y + height / 2 && move < 0) {
                move = 0;
            }
            if (transform.position.y > NewBehaviourScript.topRight.y - height / 2 && move > 0) {
                move = 0;
            }
            transform.Translate(move * Vector2.up);
        }
    }
