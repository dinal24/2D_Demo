using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {

	public Transform enemy;
	private float Lasttime = 0f;

	void SpawnEnemy(){

		var enemeyTransform = Instantiate (enemy) as Transform;
		int sign = 1;
		if (Random.value > 0.5) {
			sign = -1 ;		
		}

		Vector3 camPosition = Camera.main.transform.position;
		Debug.Log (camPosition);
		enemeyTransform.position = camPosition + new Vector3 (15 + 10* Random.value, 5 * Random.value * sign,10);

	}

	void Update(){

		if ((Time.time-Lasttime) > 1.5) {
			SpawnEnemy ();
			Lasttime = Time.time;
		}

	}

}
