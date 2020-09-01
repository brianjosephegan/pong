using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] Paddle attackingPaddle;

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        attackingPaddle.ScoreGoal();
    }
}
