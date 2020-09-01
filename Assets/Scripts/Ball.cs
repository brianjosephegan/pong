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

    AudioSource ballAudioSource;
    Rigidbody2D ballRigidbody2D;
    Vector2 initialPosition;
    bool isRestarting;

    public void Reset()
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
        ballRigidbody2D.velocity = new Vector2(xPush, yPush);
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isRestarting) { return; }

        ballAudioSource.PlayOneShot(ballCollisionSFX);

        Vector2 velocityTweak = new Vector2(Random.Range(0, randomFactor), Random.Range(0, randomFactor));
        ballRigidbody2D.velocity += velocityTweak;
    }

    private IEnumerator RestartAfterDelay()
    {
        isRestarting = true;
        yield return new WaitForSeconds(restartDelay);
        ballRigidbody2D.velocity = new Vector2(xPush, yPush);
        isRestarting = false;
    }
}
