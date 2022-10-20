using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MovingBlock : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] AudioClip sfx;
    [SerializeField] AudioSource sfxSource;

    float startingYPosition;
    public static int score;
    public static int highscore;
    

    void Start()
    {
        startingYPosition = transform.position.y;
        score = 0;
    }

    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * moveSpeed;
        if (transform.position.x <= -15)
        {
            transform.position += Vector3.right * 30f;
            float newY = startingYPosition + UnityEngine.Random.Range(-1.5f, 1.5f);
            transform.position = new Vector3(transform.position.x, newY, 0f);
            sfxSource.PlayOneShot(sfx);
            score++;

            if (score > highscore)
            {
                highscore = score;
            }
        }
    }
}