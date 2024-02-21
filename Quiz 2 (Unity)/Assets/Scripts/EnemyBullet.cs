using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = gameObject.transform.TransformDirection(Vector3.right * 50);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
