using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] Paddle attackingPaddle;

    Ball ball;

    // Start is called before the first frame update
    private void Start()
    {
        ball = FindObjectOfType<Ball>();
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        attackingPaddle.ScoreGoal();
        ball.Reset();
    }
}
