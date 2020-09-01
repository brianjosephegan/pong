using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    [SerializeField] Paddle paddle;

    Text scoreText;

    // Start is called before the first frame update
    private void Start()
    {
        scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    private void Update()
    {
        scoreText.text = paddle.Score.ToString();
    }
}
