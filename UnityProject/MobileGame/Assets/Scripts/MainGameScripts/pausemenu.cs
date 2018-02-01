using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour {
    private bool paused;
    public GameObject DifficultyCanvas;
    // Use this for initialization
    void Start()
    {
        paused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && paused == false)
        {
            paused = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && paused == true)
        {
            paused = false;
        }
        if (paused)
        { 
            Time.timeScale = 0;
            GetComponent<Canvas>().enabled = true;
        }
        if(paused == false)
        { 
            Time.timeScale = 1;
            GetComponent<Canvas>().enabled = false;
            DifficultyCanvas.GetComponent<Canvas>().enabled = false;
        }
    }


    public void Resume()
    {
        DifficultyCanvas.GetComponent<Canvas>().enabled = false;
        GetComponent<Canvas>().enabled = false;
        paused = false;
        Time.timeScale = 1;
    }
    public void Difficulty()
    {
        DifficultyCanvas.GetComponent<Canvas>().enabled = true;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }
    public void DifficultyHide()
    {
        DifficultyCanvas.GetComponent<Canvas>().enabled = false;
    }
}