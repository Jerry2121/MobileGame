using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Retry()
    {
        SceneManager.LoadScene("lvl1");
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
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
