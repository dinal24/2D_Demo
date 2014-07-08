using UnityEngine;
using System.Collections;

public class AudioHelper : MonoBehaviour {

	public static AudioHelper Instance;
	
	public AudioClip explosionSound;
	public AudioClip playerShotSound;
	public AudioClip enemyShotSound;
	
	void Awake()
	{
		//the singleton
		if (Instance != null)
		{
			Debug.LogError("Multiple instances of SoundEffectsHelper!");
		}
		Instance = this;
	}
	
	public void MakeExplosionSound()
	{
		MakeSound(explosionSound);
	}
	
	public void MakePlayerShotSound()
	{
		MakeSound(playerShotSound);
	}
	
	public void MakeEnemyShotSound()
	{
		MakeSound(enemyShotSound);
	}

	private void MakeSound(AudioClip originalClip)
	{
		AudioSource.PlayClipAtPoint(originalClip, transform.position);
	}
}
