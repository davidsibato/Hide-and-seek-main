using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float rotateSpeed = 90f;
    public AudioClip song;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag != "Player")
        {
            return;
        }
        GameManager.instance.incrementScore();
        
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);
        
    }
    void OnDestroy()
    {
        if (!audioSource.enabled) audioSource.enabled = true;
        audioSource.clip = song;
        audioSource.Play();
    }
}
