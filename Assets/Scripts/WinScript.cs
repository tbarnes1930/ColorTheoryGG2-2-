using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    public void ReturnMenu()
    {
        SceneManager.LoadScene("Title");
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
}
