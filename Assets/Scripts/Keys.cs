using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keys : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotateSpeed = 90f;
    public AudioClip song;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Player")
        {
            return;
        }
        GameManager.instance.incrementKey();
        
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);

    }
    void OnDestroy()
    {
        if (!audioSource.enabled) audioSource.enabled = true;
        audioSource.clip = song;
        audioSource.Play();
    }
}
