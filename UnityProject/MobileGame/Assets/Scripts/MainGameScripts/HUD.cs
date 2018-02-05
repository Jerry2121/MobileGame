using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {
    public GameObject HealthText;
    public GameObject LivesText;
    public GameObject CoinsText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        HealthText.GetComponent<Text>().text = ("Health: ") + PlayerPrefs.GetInt("Health");
        LivesText.GetComponent<Text>().text = ("Lives: ") + PlayerPrefs.GetInt("Lives");
        CoinsText.GetComponent<Text>().text = ("Coins: ") + PlayerPrefs.GetInt("Coins");
	}
}
