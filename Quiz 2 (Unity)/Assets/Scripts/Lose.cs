using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose : MonoBehaviour
{
    public GameObject loseMenu;

    // Start is called before the first frame update
    void Start()
    {
        loseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Player").Length <= 0)
        {
            loseMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
