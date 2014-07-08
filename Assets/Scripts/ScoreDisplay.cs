using UnityEngine;
using System.Collections;

public class ScoreDisplay : MonoBehaviour {

	private static int points = 0;
	private static int energy = 100;
	
	void OnGUI(){

		const int textwidth = 80;
		const int textheight = 40;

		string pointsscored = "Points: " + points;
		string energyleft = "Health: " + energy;
			
		GUI.TextArea (new Rect (Screen.width*3/4,
			                    Screen.height/9,
			                    textwidth,textheight), pointsscored);
		GUI.TextArea (new Rect (Screen.width/4,
		                        Screen.height/9,
		                        textwidth,textheight), energyleft);
					
	}

	public static void pointHit(){
		points += 10;
	}

	public static void energyHit(){
		energy -= 10;
	}

	public static void ResetScore(){
		points = 0;
		energy = 100;
	}

	void Update () {
	
	}
}
