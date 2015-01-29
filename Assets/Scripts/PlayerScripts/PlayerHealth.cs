using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHealth {
	private int 		startingHealth = 100;                 
	private int 		currentHealth;
	private Image 		damageImage;
	private AudioClip 	deathClip;
	private float 		flashSpeed=5f;
	private Color 		flashColour=new Color(1f,0f,0f,0.1f);
	//Animator anim;
	//AudioSource playerAudio;
	
	private bool 		damaged;

	public PlayerHealth () {
		currentHealth = startingHealth;
	}
	
	// Update is called once per frame
	public void Update () {
		if (damaged) {
			damageImage.color = flashColour;
		}
		else {
			damageImage.color=Color.Lerp (damageImage.color, Color.clear,flashSpeed*Time.deltaTime);
		}
		damaged = false;
	}

	public void TakeDamage(int amount){
		damaged = true;
		currentHealth -= amount;
		// healthSlider.value = currentHealth;
		//playerAudio.Play ();
	}

	public bool Dead(){
		// do something.
		//anim.SetTrigger ("Die");
		//playerAudio.clip = deathClip;
		//playerAudio.Play ();
		if (currentHealth <= 0) 
			return true;
		else 
			return false;
	}

	public float GetHealth() {
		return currentHealth;
	}
}
