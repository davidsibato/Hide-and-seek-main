using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private bool jumpKeyPressed;
    private float HorizontalInput;
    private float VerticalInput;
    public Joystick joystick;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        HorizontalInput = joystick.Horizontal; //Input.GetAxis("Horizontal");
        VerticalInput = joystick.Vertical; //Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(HorizontalInput, 0, VerticalInput);
        movementDirection.Normalize();
        transform.Translate(movementDirection*5*Time.deltaTime,Space.World);

        if(movementDirection != Vector3.zero){
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, 720*Time.deltaTime);

        }

    }

    
}
