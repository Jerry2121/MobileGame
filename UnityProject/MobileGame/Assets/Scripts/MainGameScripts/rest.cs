using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Win")
        {
            Application.Quit();
        }
    }
}
