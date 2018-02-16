using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChange : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "LvlBeat")
        {
            PlayerPrefs.SetInt("Lvlnum", PlayerPrefs.GetInt("Lvlnum") + 1);
            //if its Level 1 and depending on the difficulty level, it changes to its difficulty level so if im playing on normal, it will load lvl 2 normal.
            if (PlayerPrefs.GetInt("Lvlnum") == 1 && PlayerPrefs.GetInt("Difficulty") == 1)
            {
                SceneManager.LoadScene("Lvl1Beginner");
            }
            if (PlayerPrefs.GetInt("Lvlnum") == 1 && PlayerPrefs.GetInt("Difficulty") == 2)
            {
                SceneManager.LoadScene("Lvl1Normal");
            }
            if (PlayerPrefs.GetInt("Lvlnum") == 1 && PlayerPrefs.GetInt("Difficulty") == 3)
            {
                SceneManager.LoadScene("Lvl1 Insane");
            }
            //if its Level 2 and depending on the difficulty level, it changes to its difficulty level so if im playing on normal, it will load lvl 3 normal.
            if (PlayerPrefs.GetInt("Lvlnum") == 2 && PlayerPrefs.GetInt("Difficulty") == 1)
            {
                SceneManager.LoadScene("Lvl2");
            }
            if (PlayerPrefs.GetInt("Lvlnum") == 2 && PlayerPrefs.GetInt("Difficulty") == 2)
            {
                SceneManager.LoadScene("Lvl2 Normal");
            }
            if (PlayerPrefs.GetInt("Lvlnum") == 2 && PlayerPrefs.GetInt("Difficulty") == 3)
            {
                SceneManager.LoadScene("Lvl2 Insane");
            }
            //if its Level 3 and I beat the level, it will send you to the win screen.
            if (PlayerPrefs.GetInt("Lvlnum") == 3 && PlayerPrefs.GetInt("Difficulty") == 1)
            {
                SceneManager.LoadScene("Win");
            }
            if (PlayerPrefs.GetInt("Lvlnum") == 3 && PlayerPrefs.GetInt("Difficulty") == 2)
            {
                SceneManager.LoadScene("Win");
            }
            if (PlayerPrefs.GetInt("Lvlnum") == 3 && PlayerPrefs.GetInt("Difficulty") == 3)
            {
                SceneManager.LoadScene("Win");
            }
        }
    }
}
