using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void StartGame()
    {
        SceneManager.LoadScene("SpaceGame");
        
    }

    public void Quitter()
    {
        Debug.Log("QUITTE");
        Application.Quit();
    }
}
