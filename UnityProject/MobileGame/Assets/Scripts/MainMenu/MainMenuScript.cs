using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

    public void Play()
    {
        SceneManager.LoadScene("Lvl1Beginner");
        PlayerPrefs.SetInt("Lvlnum", 1);
        if (PlayerPrefs.GetInt("Difficulty") == 1)
        {
            PlayerPrefs.SetInt("Health", 10);
            PlayerPrefs.SetInt("Lives", 5);
            PlayerPrefs.SetInt("Coins", 0);
        }
        if (PlayerPrefs.GetInt("Difficulty") == 2)
        {
            PlayerPrefs.SetInt("Health", 5);
            PlayerPrefs.SetInt("Lives", 3);
            PlayerPrefs.SetInt("Coins", 0);
        }
        if (PlayerPrefs.GetInt("Difficulty") == 3)
        {
            PlayerPrefs.SetInt("Health", 1);
            PlayerPrefs.SetInt("Lives", 1);
            PlayerPrefs.SetInt("Coins", 0);
        }
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
