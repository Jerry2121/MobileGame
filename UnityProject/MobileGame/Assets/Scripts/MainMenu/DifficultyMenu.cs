using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DifficultyMenu : MonoBehaviour {
    public GameObject CurrentyDifficultyText;
    
	// Use this for initialization
	void Start () {
        
    }
    public void Beginner()
    {
        PlayerPrefs.SetInt("Difficulty", 1);
    }
    public void Normal()
    {
        PlayerPrefs.SetInt("Difficulty", 2);
    }
    public void Insane()
    {
        PlayerPrefs.SetInt("Difficulty", 3);
    }
    public void GoBack()
    {
        SceneManager.LoadScene("MainMenu");
    }
    // Update is called once per frame
    void Update () {
        if (PlayerPrefs.GetInt("Difficulty") == 1)
        {
            CurrentyDifficultyText.GetComponent<Text>().text = "Current Difficulty: Beginner";
        }
        if (PlayerPrefs.GetInt("Difficulty") == 2)
        {
            CurrentyDifficultyText.GetComponent<Text>().text = "Current Difficulty: Normal";
        }
        if (PlayerPrefs.GetInt("Difficulty") == 3)
        {
            CurrentyDifficultyText.GetComponent<Text>().text = "Current Difficulty: Insane";
        }
    }
}
