using UnityEngine;
using System.Collections;

public class SpecialEffectHelper : MonoBehaviour {


	public static SpecialEffectHelper Instance;
	
	public ParticleSystem smokeEffect;
	public ParticleSystem fireEffect;
	
	void Awake()
	{
		// Register the singleton
		if (Instance != null)
		{
			Debug.LogError("Multiple instances of SpecialEffectsHelper!");
		}
		
		Instance = this;
	}
	
	public void Explosion(Vector3 position)
	{
		// Smoke 
		instantiate(smokeEffect, position);

		// Fire 
		instantiate(fireEffect, position);
	}
	

	private ParticleSystem instantiate(ParticleSystem prefab, Vector3 position)
	{
		ParticleSystem newParticleSystem = Instantiate(
			prefab,
			position,
			Quaternion.identity
			) as ParticleSystem;
		
		//it will be destroyed
		Destroy(
			newParticleSystem.gameObject,
			newParticleSystem.startLifetime
			);
		
		return newParticleSystem;
	}

}
