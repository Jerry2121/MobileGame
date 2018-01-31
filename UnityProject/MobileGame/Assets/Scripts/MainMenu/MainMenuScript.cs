using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

    public void Play()
    {
        SceneManager.LoadScene("Lvl1");
    }
    public void Difficulty()
    {
        SceneManager.LoadScene("MainMenu#2");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
