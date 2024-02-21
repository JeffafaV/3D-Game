using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string levelName;

    public void LevelChange()
    {
        SceneManager.LoadScene(levelName);
        Time.timeScale = 1;
    }
}
