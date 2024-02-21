using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pauseMenu;

    //Scene currentScene = SceneManager.GetActiveScene();


    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) // sceneName == "MainLevel"
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
}
