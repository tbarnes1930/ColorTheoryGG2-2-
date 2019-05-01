using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Tutorial");
        Cursor.visible = false;
    }
    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }
    public void QuitGame()
    {
        Cursor.visible = true;
        Application.Quit();
    }
}