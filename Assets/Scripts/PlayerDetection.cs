using UnityEngine;

public class PlayerDetection : MonoBehaviour
{
    public float seekerVision;
    public float moveSpeed;
    private Transform playerPosition;
    private Vector3 distanceFromPlayer;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        distanceFromPlayer = playerPosition.position - transform.position;
        if (distanceFromPlayer.magnitude < seekerVision)
        {
            // Move towards the player
            rb.velocity = distanceFromPlayer.normalized * moveSpeed;
        }
        else
        {
            // Stop moving if the player is out of range
            rb.velocity = Vector3.zero;
        }
    }
}
