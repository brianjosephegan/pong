using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinManager : MonoBehaviour
{
    [SerializeField] Canvas scoreCanvas;
    [SerializeField] Canvas winCanvas;
    [SerializeField] Text winText;

    public bool GameOver => gameOver;

    private bool gameOver;

    public void TriggerWinScenario(Paddle winningPaddle)
    {
        winCanvas.gameObject.SetActive(true);
        winText.text = $"{winningPaddle.PlayerName} Wins!";

        scoreCanvas.gameObject.SetActive(false);
        foreach (var paddle in FindObjectsOfType<Paddle>())
        {
            paddle.gameObject.SetActive(false);
        }
        foreach (var ball in FindObjectsOfType<Ball>())
        {
            ball.gameObject.SetActive(false);
        }

        gameOver = true;
    }
}
