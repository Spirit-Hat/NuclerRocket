using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour
{    
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {    
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
        Destroy(gameObject,0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
