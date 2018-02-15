using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour {
    public GameObject DifficultyCanvas;
    public GameObject PauseCanvas;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Resume()
    {
        DifficultyCanvas.GetComponent<Canvas>().enabled = false;
        GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1;
    }
    public void Difficulty()
    {
        DifficultyCanvas.GetComponent<Canvas>().enabled = true;
        PauseCanvas.GetComponent<Canvas>().enabled = false;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }
    public void DifficultyHide()
    {
        DifficultyCanvas.GetComponent<Canvas>().enabled = false;
        PauseCanvas.GetComponent<Canvas>().enabled = true;
    }
    public void PauseButton()
    {
        Time.timeScale = 0;
        PauseCanvas.GetComponent<Canvas>().enabled = true;
    }
}