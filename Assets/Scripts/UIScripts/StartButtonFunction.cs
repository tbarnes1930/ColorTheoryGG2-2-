using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonFunction : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Button Pushed");
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Tutorial");
    }
}
