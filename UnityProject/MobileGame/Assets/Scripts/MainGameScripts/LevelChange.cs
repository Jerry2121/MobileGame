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
        }
    }
}
