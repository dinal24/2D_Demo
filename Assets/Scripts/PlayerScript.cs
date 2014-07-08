using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public Vector2 speed = new Vector2(75,75);
	private Vector2 movement;


	void Update () {

		moveEditor();
		fire ();


		bound ();
	}


	void FixedUpdate(){
		move ();
	}

	void moveEditor(){
		float inX = Input.GetAxis ("Horizontal");
		float inY = Input.GetAxis ("Vertical");

		movement = new Vector2(speed.x * inX, speed.y * inY);


	}

	void moveMobile(){

	}

	void move(){

		rigidbody2D.velocity = movement;
	}

	void fire(){
		bool shoot = Input.GetButtonDown ("Fire1");
		if (shoot) {
			WeaponScript weapon = GetComponent<WeaponScript>();
			if(weapon != null){
				weapon.Attack(false);
				AudioHelper.Instance.MakePlayerShotSound();
			}
		}
	}

	void bound(){
		var dist = (transform.position - Camera.main.transform.position).z;
		
		var leftBorder = Camera.main.ViewportToWorldPoint(
			new Vector3(0, 0, dist)
			).x;
		
		var rightBorder = Camera.main.ViewportToWorldPoint(
			new Vector3(1, 0, dist)
			).x;
		
		var topBorder = Camera.main.ViewportToWorldPoint(
			new Vector3(0, 0, dist)
			).y;
		
		var bottomBorder = Camera.main.ViewportToWorldPoint(
			new Vector3(0, 1, dist)
			).y;
		
		transform.position = new Vector3(
			Mathf.Clamp(transform.position.x, leftBorder, rightBorder),
			Mathf.Clamp(transform.position.y, topBorder, bottomBorder),
			transform.position.z
			);
	}

	void OnDestroy(){
		transform.parent.gameObject.AddComponent<GameOverScript>();
	}
}
