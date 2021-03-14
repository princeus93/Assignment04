using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private bool isPinned = false;

    public AudioSource collisionSound;
    public AudioSource explosionSound;

    public float speed = 20f;
    public Rigidbody2D rb;

    private void Start()
    {
        collisionSound = GetComponent<AudioSource>();
        explosionSound = GetComponent<AudioSource>();
    }

    void Update()
    {

        if (!isPinned)
        {
            
                rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
            
        }
        
        
    }

    public void adjustSpeed(float newSpeed)
    {
        speed = newSpeed;
    }


    

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Rotator")
        {
            transform.SetParent(col.transform);
            Score.ScoreCount++;
            isPinned = true;

            collisionSound.Play();
            
        } else if(col.tag == "Pin")
        {
            explosionSound.Play();
            FindObjectOfType<GameManager>().EndGame();
        }
    }





}
