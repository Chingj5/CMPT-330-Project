using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PlayerHunger : MonoBehaviour {
	public float startingHunger = 14400;
	public float currentHunger;
	public Image hungerImage;
	public AudioClip deathClip;
	bool isDead;
	public Text hungerText;
	int hunger;
	public PlayerHealth playerHealth;
	GameObject player;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
		currentHunger = startingHunger;
		playerHealth = player.GetComponent<PlayerHealth> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (hunger > 0) {
			currentHunger = currentHunger - 1;
		}
		hunger = (int)((currentHunger / startingHunger) * 100);
		hungerText.text=hunger.ToString();
		if (hunger <= 0) {
			playerHealth.playerStarves();
		}
	}
}
