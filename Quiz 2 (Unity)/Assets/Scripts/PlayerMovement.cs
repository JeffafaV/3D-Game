using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpSpeed;

    private Vector3 moveHorizontalR = Vector3.forward;
    private Vector3 moveHorizontalL = Vector3.back;
    private Vector3 moveVerticalB = Vector3.right;
    private Vector3 moveVerticalF = Vector3.left;
    private Vector3 moveUp = Vector3.up;

    public Rigidbody rb;

    private bool onFloor;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(moveVerticalF * speed);
            Debug.Log("Forward");
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(moveVerticalB * speed);
            Debug.Log("Back");
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(moveHorizontalR * speed);
            Debug.Log("Right");
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(moveHorizontalL * speed);
            Debug.Log("Left");
        }

        if (Input.GetKeyDown(KeyCode.Space) && onFloor == true)
        {
            rb.AddForce(moveUp * jumpSpeed);
            onFloor = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            onFloor = true;
        }
    }

}