using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Paddle : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] string inputAxis;
    [SerializeField] int score = 0;
    [SerializeField] bool isPlayerTwo;

    Rigidbody2D paddleRigidbody2D;
    Ball ball;
    bool autoPlayEnabled;

    public int Score => score;

    public void ScoreGoal()
    {
        score++;
    }

    // Start is called before the first frame update
    private void Start()
    {
        paddleRigidbody2D = GetComponent<Rigidbody2D>();
        ball = FindObjectOfType<Ball>();

        if (isPlayerTwo && PlayerPrefsController.GetNumberOfPlayer() == 1)
        {
            autoPlayEnabled = true;
        }
    }

    // Update is called once per frame
    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (autoPlayEnabled)
        {
            float newY = ball.transform.position.y;
            transform.position = new Vector2(transform.position.x, newY);
        }
        else
        {
            float controlThrow = CrossPlatformInputManager.GetAxis(inputAxis); // value between -1 and +1
            Vector2 paddleVelocity = new Vector2(paddleRigidbody2D.velocity.x, controlThrow * moveSpeed);
            paddleRigidbody2D.velocity = paddleVelocity;
        }
    }
}
