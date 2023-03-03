using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinNLoseMenu : MonoBehaviour
{
    public void ReloadGame()
    {
        SceneManager.LoadScene("SpaceGame");
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);

    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
