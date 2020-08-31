using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Paddle : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;

    Rigidbody2D paddleRigidbody2D;

    // Start is called before the first frame update
    private void Start()
    {
        paddleRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        Move();
    }

    private void Move()
    {
        float controlThrow = CrossPlatformInputManager.GetAxis("Vertical"); // value between -1 and +1
        Vector2 paddleVelocity = new Vector2(paddleRigidbody2D.velocity.x, controlThrow * moveSpeed);
        paddleRigidbody2D.velocity = paddleVelocity;
    }
}
