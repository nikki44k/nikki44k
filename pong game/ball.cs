using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    [SerializeField] private float intialVelocity = 4f;
    [SerializeField] private float velocityMultiplier = 1.1f;

    private Rigidbody2D ballRb;

    private void Start()
    {
        ballRb = GetComponent<Rigidbody2D>();
        Launch();
    }

    private void Launch() {
        float xVelocity = Random.Range(0, 2) == 0 ? 1 : -1;
        float yVelocity = Random.Range(0, 2) == 0 ? 1 : -1;
        ballRb.velocity = new Vector2(xVelocity, yVelocity) * intialVelocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("paddle"))
        {
            ballRb.velocity *= velocityMultiplier;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("goal1"))
        {
            manager.Instance.p2Scored();
            manager.Instance.Restart();
            Launch();
        }
        else {
            manager.Instance.p1Scored();
            manager.Instance.Restart();
            Launch(); 
        }
    }
}
