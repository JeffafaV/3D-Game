using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = gameObject.transform.TransformDirection(Vector3.left * 25);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
