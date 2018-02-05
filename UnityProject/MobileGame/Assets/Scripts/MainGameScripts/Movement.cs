using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	// Use this for initialization
	public float moveSpeed = 1.0f;
	public float jumpSpeed = 1.0f;
	private bool grounded = false;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
		velocity.x = moveSpeed;
		GetComponent<Rigidbody2D> ().velocity = velocity;
		if (Input.GetButtonDown("Jump")&& grounded) 
		{
			GetComponent<Rigidbody2D> ().AddForce(new Vector2 (0, 100 * jumpSpeed));
			grounded = false;
		}
	}

void OnTriggerEnter2D(Collider2D collision)
	{
		//if we collide with anything we are grouned
		//layer 8 is ground layer
		if (collision.gameObject.layer == 8) {
			grounded = true;
		}
	}
			void OnTriggerExit2D(Collider2D collision)
	{
		//if we collide with anything we are grouned
		//layer 8 is ground layer
		if (collision.gameObject.layer == 8) {
			grounded = false;
		}
	}
	void OnTriggerStay2D(Collider2D collision)
	{
		//if we collide with anything we are grouned
		//layer 8 is ground layer
		if (collision.gameObject.layer == 8) {
			grounded = true;

		}
	}
}