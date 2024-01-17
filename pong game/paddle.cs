using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private float speed = 7f;
    [SerializeField] private bool is_paddle1;
    private float yBound = 3.75f;


    // Update is called once per frame
    void Update()
    {
        float movement;

        if (is_paddle1)
        {
            movement = Input.GetAxisRaw("Vertical");
        }
        else {
            movement = Input.GetAxisRaw("Vertical2");
        }

        Vector2 paddlePosition = transform.position;
        paddlePosition.y = Mathf.Clamp(paddlePosition.y + movement * speed * Time.deltaTime, -yBound, yBound);
        transform.position = paddlePosition;
    }

}
