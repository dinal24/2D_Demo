using UnityEngine;
using System.Collections;

public class PlatformScroll : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (renderer.IsVisibleFrom(Camera.main) == false && (Camera.main.transform.position.x > transform.position.x + 18) )
		{
			Vector3 newlocation = new Vector3(Camera.main.transform.position.x + 50 + 10* Random.value,0,0); 
			gameObject.transform.Translate(newlocation);
		}
	}
}
