using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {
    public GameObject StarCanvas;
    public GameObject GarnetCanvas;
    public GameObject BannanaCanvas;
    void Update()
    {
        if(PlayerPrefs.GetInt("InsaneBeat") == 1)
        {
            StarCanvas.GetComponent<Canvas>().enabled = true;
        }
        if (PlayerPrefs.GetInt("SecretHit") == 1)
        {
            GarnetCanvas.GetComponent<Canvas>().enabled = true;
        }
        if (PlayerPrefs.GetInt("AnyDiffBeat") == 1)
        {
            BannanaCanvas.GetComponent<Canvas>().enabled = true;
        }
    }
    public void Play()
    {
        PlayerPrefs.SetInt("Lvlnum", 1);
        if (PlayerPrefs.GetInt("Difficulty") == 1)
        {
            PlayerPrefs.SetInt("Health", 10);
            PlayerPrefs.SetInt("Lives", 5);
            PlayerPrefs.SetInt("Coins", 0);
            SceneManager.LoadScene("Lvl1Beginner");
            }
        if (PlayerPrefs.GetInt("Difficulty") == 2)
        {
            PlayerPrefs.SetInt("Health", 5);
            PlayerPrefs.SetInt("Lives", 3);
            PlayerPrefs.SetInt("Coins", 0);
            SceneManager.LoadScene("Lvl1Normal");
            }
        if (PlayerPrefs.GetInt("Difficulty") == 3)
        {
            PlayerPrefs.SetInt("Health", 1);
            PlayerPrefs.SetInt("Lives", 1);
            PlayerPrefs.SetInt("Coins", 0);
            SceneManager.LoadScene("Lvl1 Insane");
            }
    }
    public void Difficulty()
    {
        SceneManager.LoadScene("MainMenu#2");
    }
    public void Reset()
    {
        PlayerPrefs.SetInt("InsaneBeat", 0);
        PlayerPrefs.SetInt("SecretHit", 0);
        PlayerPrefs.SetInt("AnyDiffBeat", 0);
        StarCanvas.GetComponent<Canvas>().enabled = false;
        GarnetCanvas.GetComponent<Canvas>().enabled = false;
        BannanaCanvas.GetComponent<Canvas>().enabled = false;
    }
    public void Quit()
    {
        Application.Quit();
    }
}
