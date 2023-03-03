using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool EndGame = false;
    public GameObject WinScreen;
    public GameObject GameOverScreen;
    private void Start()
    {
        

    }

    public void WinningScreen()
    {
        WinScreen.SetActive(true);
    }


    public void GameOver()
    {
        if (EndGame == false)
        {
            EndGame = true;
            Debug.Log("CHEH");
            GameOverScreen.SetActive(true);
        }
        
        
    }
}
