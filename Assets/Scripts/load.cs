using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load : MonoBehaviour
{
    public void Gamestart()
    {
        SceneManager.LoadScene(1);
        Debug.Log("GameStart");
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
        Debug.Log("ReStart");
    }
    public void Home()
    {
        SceneManager.LoadScene(2);
        Debug.Log("Home");
    }
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exit");
    }
}
