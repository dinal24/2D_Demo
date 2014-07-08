using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	void OnGUI(){

		const int buttonwidth = 120;
		const int buttonheight = 60;

		const int textwidth = 240;
		const int textheight = 60;

		string message = "Use arrow keys to move\nPress Ctrl to shoot";
		GUI.TextArea (new Rect (Screen.width / 2 - (textwidth / 2),
			                    Screen.height /(3.5f) - (textheight / 2),
			                    textwidth,textheight), message);

		if (GUI.Button (new Rect (Screen.width / 2 - (buttonwidth / 2),
		                       Screen.height / 2 - (buttonheight / 2),
		                       buttonwidth, buttonheight), "Play")) {
			Application.LoadLevel("Stage1");		
		}

	}
}
