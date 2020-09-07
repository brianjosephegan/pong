using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] float xPush = -10.0f;
    [SerializeField] float yPush = 0f;
    [SerializeField] float randomFactor = 0.2f;
    [SerializeField] float restartDelay = 2.0f;
    [SerializeField] AudioClip ballCollisionSFX;
    [SerializeField] AudioClip goalScoredSFX;

    AudioSource ballAudioSource;
    Rigidbody2D ballRigidbody2D;
    Vector2 initialPosition;

    public void Stop()
    {
        ballRigidbody2D.velocity = Vector2.zero;
    }

    public void Restart()
    {
        ballRigidbody2D.velocity = Vector2.zero;
        transform.position = initialPosition;
        StartCoroutine(RestartAfterDelay());
    }

    // Start is called before the first frame update
    private void Start()
    {
        initialPosition = transform.position;
        ballAudioSource = GetComponent<AudioSource>();
        ballRigidbody2D = GetComponent<Rigidbody2D>();

        Restart();
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Paddle>() != null)
        {
            ballAudioSource.PlayOneShot(ballCollisionSFX, PlayerPrefsController.GetSoundVolume() / 100);
        }
        else
        {
            ballAudioSource.PlayOneShot(goalScoredSFX, PlayerPrefsController.GetSoundVolume() / 100);
        }

        Vector2 velocityTweak = new Vector2(Random.Range(0, randomFactor), Random.Range(0, randomFactor));
        ballRigidbody2D.velocity += velocityTweak;
    }

    private IEnumerator RestartAfterDelay()
    {
        yield return new WaitForSeconds(restartDelay);
        ballRigidbody2D.velocity = new Vector2(xPush, yPush);
    }
}
