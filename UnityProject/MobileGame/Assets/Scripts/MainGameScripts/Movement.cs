using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    Animator anim;

	// Use this for initialization
	public float moveSpeed = 1.0f;
	public float jumpSpeed = 1.0f;
	private bool grounded = false;
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
		velocity.x = moveSpeed;
		GetComponent<Rigidbody2D> ().velocity = velocity;
		if (Input.GetMouseButtonDown(0) && grounded) 
		{
			GetComponent<Rigidbody2D> ().AddForce(new Vector2 (0, 100 * jumpSpeed));
			grounded = false;
		}
        if(grounded == true)
        {
            anim.SetBool("isJumping", false);
        }
        if(grounded == false)
        {
            anim.SetBool("isJumping", true);
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