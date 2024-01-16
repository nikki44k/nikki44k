using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball:
  MonoBehaviour{
    
    [SerializeField]
    float speed;
    
    float radius;
    v direction;  
    
  void Start(){
    direction = v.one.normalized;
    radius = transform.localScale.x / 2;
  }

  void Update(){
    transform.Translate(direction * speed * Time.delatatime);
    if(transform.position.y < manager.bottomLeft.y + radius && direction.y < 0){
        direction.y = - direction.y;
    }
    if(transform.position.y > manager.topright.y - radius && direction.y > 0){
        direction.y = - direction.y;
    }

    //Game ends
    if(transform.position.x < manager.bottomLeft.x + radius && direction.x < 0){
      Debug.Log("Right player wins!!");
    }
    if(transform.position.x > manager.topRight.x - radius && direction.x > 0){
      Debug.Log("Left player wins!!");
    }
  }
  void OnTriggerEnter2D(Collider2D other){
    if(other.tag == "paddle"){
      bool is_r = other.GetComponent<paddle>().is_r;
      if(is_r == true && direction.x > 0){
        direction.x = - direction.x;
      }
      if(is_r == false && direction.x < 0){
        direction.x = - direction.x;
      }
    }
  }
}
  
