using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;

    private AudioSource audioSource;

    // public Transform transfor;

    public GameObject explosion; 
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
        rb.velocity = transform.up * speed;
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Debug.Log(other.name);
        // Instantiate(firePrefab, firePoint.position, firePoint.rotation);

        var transform1 = transform;
        Instantiate(explosion,transform1.position, transform1.rotation);
        
        Destroy(gameObject);
    }
}
