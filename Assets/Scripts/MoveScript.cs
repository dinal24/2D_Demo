using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {
	public Vector2 speed = new Vector2(50,50);
	public Vector2 direction = new Vector2(-1,0);
	private Vector2 movement;
	
	// Update is called once per frame
	void Update () {
		moveCalculate ();
		move ();
	}
	/*
	void FixedUpdate(){
		move ();
	}
*/
	void moveCalculate(){
		movement = new Vector2(speed.x * direction.x, speed.y * direction.y);
		//movement *= Time.deltaTime;
	}

	void move(){
		rigidbody2D.velocity = movement;
	}

}
