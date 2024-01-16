using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle: 
  MonoBehaviour{
    [SerializeField]
    float speed;
    float height;
    bool is_r;
    string input;
    void start(){
      height = transform.localScale.y;      
    }
    
    public void Init(bool is_rpaddle){
      is_r = is_rpaddle;
      v pos = v.zero;
      if (is_rpaddle){      //paddle will be on the rightside
        pos = new v(manager.topRight.x, 0);   
        pos -= v.right * transform.localScale.x;  //moves to left
        input = "PaddleRight";
        
      }else{                //paddle will be on the left side
        pos = new v(manager.bottomLeft.x, 0);
        pos += v.right * transform.localScale.x;  //moves to right
        input = "PaddleLeft";
      }
      transform.position = pos;
      transform.name = input;
    }

    void update(){
      float move = Input.GetAxis(input) * Time.deltaTime * speed;
      transform.Translate(move * v.up);
    }
    
  }
