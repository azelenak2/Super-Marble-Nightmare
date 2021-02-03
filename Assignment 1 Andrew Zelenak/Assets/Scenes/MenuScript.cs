using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public string startSceneName;

    public void StartPressed()
    {
        SceneManager.LoadScene(1);
    }
    public void Closegame()
    {
        Application.Quit();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }

    }
}

