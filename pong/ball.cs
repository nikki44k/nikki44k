using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour{
    
    [SerializeField]
    float speed;

    float radius;
    Vector2 direction;

    void Start()
    {
        direction = Vector2.one.normalized;
        radius = transform.localScale.x / 2;
    }

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        if (transform.position.y < NewBehaviourScript.bottomLeft.y + radius && direction.y < 0)
        {
            direction.y = -direction.y;
        }
        if (transform.position.y > NewBehaviourScript.topRight.y - radius && direction.y > 0)
        {
            direction.y = -direction.y;
        }

        //Game ends
        if (transform.position.x < NewBehaviourScript.bottomLeft.x + radius && direction.x < 0)
        {
            Debug.Log("Right player wins!!");
            Time.timeScale = 0;
            enabled = false;
        }
        if (transform.position.x > NewBehaviourScript.topRight.x - radius && direction.x > 0)
        {
            Debug.Log("Left player wins!!");
            Time.timeScale = 0;
            enabled = false;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "paddle"){
            bool is_r = other.GetComponent<paddle>().is_r;
            if (is_r == true && direction.x > 0)
            {
                direction.x = -direction.x;
            }
            if (is_r == false && direction.x < 0)
            {
                direction.x = -direction.x;
            }
        }
    }
}
