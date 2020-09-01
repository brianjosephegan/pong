﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] float xPush = -10.0f;
    [SerializeField] float yPush = 0f;
    [SerializeField] float randomFactor = 0.2f;
    [SerializeField] AudioClip ballCollisionSFX;

    AudioSource ballAudioSource;
    Rigidbody2D ballRigidbody2D;

    // Start is called before the first frame update
    private void Start()
    {
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
        ballAudioSource.PlayOneShot(ballCollisionSFX);

        Vector2 velocityTweak = new Vector2(Random.Range(0, randomFactor), Random.Range(0, randomFactor));
        ballRigidbody2D.velocity += velocityTweak;
    }
}
