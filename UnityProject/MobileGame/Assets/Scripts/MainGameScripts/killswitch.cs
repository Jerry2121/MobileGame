﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class killswitch : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(PlayerPrefs.GetInt("Health") <= 0)
        {
            PlayerPrefs.SetInt("Lives", PlayerPrefs.GetInt("Lives") - 1);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            if (PlayerPrefs.GetInt("Difficulty") == 1)
            {
                PlayerPrefs.SetInt("Health", 10);
                PlayerPrefs.SetInt("Coins", 0);
            }
            if (PlayerPrefs.GetInt("Difficulty") == 2)
            {
                PlayerPrefs.SetInt("Health", 5);
                PlayerPrefs.SetInt("Coins", 0);
            }
            if (PlayerPrefs.GetInt("Difficulty") == 3)
            {
                PlayerPrefs.SetInt("Health", 1);
                PlayerPrefs.SetInt("Coins", 0);
            }
        }
    
        if(PlayerPrefs.GetInt("Lives") <= 0)
        {
            SceneManager.LoadScene("Lose");
        }
        if (PlayerPrefs.GetInt("Coins") >= 10)
        {
            PlayerPrefs.SetInt("Lives", PlayerPrefs.GetInt("Lives") + 1);
            PlayerPrefs.SetInt("Coins", 0);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Kill")
        {
            PlayerPrefs.SetInt("Lives", PlayerPrefs.GetInt("Lives") - 1);
            if (PlayerPrefs.GetInt("Difficulty") == 1)
            {
                PlayerPrefs.SetInt("Health", 10);
                PlayerPrefs.SetInt("Coins", 0);
            }
            if (PlayerPrefs.GetInt("Difficulty") == 2)
            {
                PlayerPrefs.SetInt("Health", 5);
                PlayerPrefs.SetInt("Coins", 0);
            }
            if (PlayerPrefs.GetInt("Difficulty") == 3)
            {
                PlayerPrefs.SetInt("Health", 1);
                PlayerPrefs.SetInt("Coins", 0);
            }
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (collision.gameObject.tag == "Obstical")
        {
            PlayerPrefs.SetInt("Health", PlayerPrefs.GetInt("Health") - 2);
        }
        if (collision.gameObject.tag == "Secretbut")
        {
            PlayerPrefs.SetInt("SecretHit", 1);
            Destroy(collision.gameObject);
        }
    }
    
}
