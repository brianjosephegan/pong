using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] float xPush = -10.0f;
    [SerializeField] float yPush = 0f;

    Rigidbody2D ballRigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        ballRigidbody2D = GetComponent<Rigidbody2D>();
        ballRigidbody2D.velocity = new Vector2(xPush, yPush);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
