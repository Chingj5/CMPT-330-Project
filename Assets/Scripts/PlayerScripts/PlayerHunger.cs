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
	// Use this for initialization
	void Start () {
		currentHunger = startingHunger;

	}
	
	// Update is called once per frame
	void Update () {
		currentHunger=currentHunger-1;
		hunger = (int)((currentHunger / startingHunger) * 100);
		hungerText.text=hunger.ToString();
	}
}
