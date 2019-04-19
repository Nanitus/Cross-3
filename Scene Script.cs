using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM_SceneLoader : MonoBehaviour
{

    public void START()
    {
        SceneManager.LoadScene(1);
    }

    public void RETRY()
    {
        SceneManager.LoadScene(1);
        GameManager.instance.Health = 3;
    }

    public void CONTROLS()
    {
        SceneManager.LoadScene(2);
    }

    public void BACK()
    {
        SceneManager.LoadScene(0);
    }

    public void RELOAD()
    {
        SceneManager.LoadScene(0);
        GameManager.instance.Health = 3;
        GameManager.instance.Lives = 3;
    }

    public void EXIT()
    {
        Application.Quit();
    }
}