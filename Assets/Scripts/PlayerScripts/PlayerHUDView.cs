using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class PlayerHUDView : MonoBehaviour {

	private GameObject db_object;
	private PlayerDatabase db;

	public Text hunger;
	public Text thirst;
	public Slider health;

	void Start() {
		db_object = GameObject.Find ("PlayerDB");
		db = db_object.GetComponent<PlayerDatabase>();
	}

	void LateUpdate() {
		hunger.text = db.satiation.GetHungerPercent ();
		thirst.text = db.satiation.GetThirstPercent ();
		health.value = db.health.GetHealth();
	}
}