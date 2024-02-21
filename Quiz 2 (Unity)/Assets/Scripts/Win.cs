using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject winMenu;

    // Start is called before the first frame update
    void Start()
    {
        winMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Enemy").Length <= 0)
        {
            winMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
