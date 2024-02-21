using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadCamera : MonoBehaviour
{
    public GameObject deadCamera;

    // Start is called before the first frame update
    void Start()
    {
        deadCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Camera").Length == 1 && deadCamera != null)
        {
            deadCamera.SetActive(true);
        }
    }
}
