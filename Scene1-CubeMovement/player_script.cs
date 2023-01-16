using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_script : MonoBehaviour
{

    // First define speed to move at
    public float speed;
    public Rigidbody rb;
    public int jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // player presses W
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, speed); // by default unity recognizes this as a cube
        }
        // player presses A
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed, 0, 0); // by default unity recognizes this as a cube
        }
        // player presses S
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -speed); // by default unity recognizes this as a cube
        }
        // player presses D
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed, 0, 0); // by default unity recognizes this as a cube
        }

        // to make player jump when press space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0, jumpForce, 0); //add force to rigidbody in y direction | Change this value in unity
        }
    }
}
