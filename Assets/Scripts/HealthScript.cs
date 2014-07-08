using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {

	public int hp = 5;
	public bool isEnemy = true;
	private string message;

	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D collider2D) {
		ShotScript shotscript = collider2D.gameObject.GetComponent<ShotScript> ();

		if (shotscript != null) {
			if (shotscript.isEnemyShot != isEnemy){
				hp -= shotscript.damage;
				if(!isEnemy){
					ScoreDisplay.energyHit();
				}
					


				Destroy(shotscript.gameObject);
				if (hp<=0){
					SpecialEffectHelper.Instance.Explosion(transform.position);
					AudioHelper.Instance.MakeExplosionSound();
					if(isEnemy){
						ScoreDisplay.pointHit();
					}
					Destroy(gameObject);
				}
			}		
		}

	}


}
