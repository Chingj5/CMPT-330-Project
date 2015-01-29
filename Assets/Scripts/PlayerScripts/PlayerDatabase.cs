using UnityEngine;
using System.Collections;

public class PlayerDatabase : MonoBehaviour {

	public PlayerHealth 		health;
	public PlayerSatiation 		satiation;//hunger thirst
	public bool 				playerAlive = true;
	public string 				deathReason;

	private void EverySecondUpdate() {
		satiation.Update ();
		if (satiation.Dead ()) {
			playerAlive = false;
			deathReason = "Your body stopped functioning.";
		}
	}

	// Use this for initialization
	void Start () {
		health = new PlayerHealth ();
		satiation = new PlayerSatiation ();
		InvokeRepeating ("EverySecondUpdate", 1.0f, 1.0f);
	}

	// Update is called once per frame
	void Update () {
		health.Update ();
		if (health.Dead ()) {
			playerAlive = false;
			deathReason = "You got mauled by a zombie!";
		}
	}
}
