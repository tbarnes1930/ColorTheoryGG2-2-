using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void ReturnMenu()
    {
        SceneManager.LoadScene("Title");
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
}
