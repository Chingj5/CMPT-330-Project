using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// Alexander Martin
/// CMPT 330 Project 
/// 
/// <summary>
/// Handles player health and thirst.
/// </summary>
public class PlayerSatiation {

	private const float MAX_HUNGER = 100.0f;
	private const float MAX_THIRST = 100.0f;
	// Unused?  May it be useful?
	private const float MAX_DELAY = 2000.0f;

	// If achieve no hunger or thirst after feed/drink increase this amount
	// else increase by half.
	private const float HUNGER_DELAY_INCREASE = 300.0f;
	private const float THIRST_DELAY_INCREASE = 180.0f;

	public float hunger = 0.0f;
	public float thirst = 0.0f;

	// For future necessaryness?
    public float increase_in_seconds = 1.0f;
	private float increase_modifier = 1.0f; // increase_in_seconds; 
	private const float increase = 0.5f; // increase by a percent every 2 seconds.

	// Delays are in seconds.
	private float thirst_delay = 60.0f;
	private float hunger_delay = 180.0f; 

	/// <summary>
	/// Allow player to set custom, but if not set default at no hunger or thirst.
	/// </summary>
	public PlayerSatiation () {
		// gotta be a better way to do this.
		// player = GameObject.FindGameObjectWithTag ("Player");
		// health = player.GetComponent<PlayerHealth> ();

	}

	/// <summary>
	/// Feed the specified feed.
	/// </summary>
	/// <param name="feed">Amount to decrease hunger by</param>
	public void feed (float feed) {
		hunger = Mathf.Clamp (hunger - feed, 0, MAX_HUNGER);

		if (hunger == 0) {
			hunger_delay += HUNGER_DELAY_INCREASE;
		} else {
			hunger_delay += (HUNGER_DELAY_INCREASE / 2);
		}
	}

	/// <summary>
	/// Drink specified amount
	/// </summary>
	/// <param name="feed">Amount to decrease thirst by</param>
	public void drink (float drink) {
		thirst = Mathf.Clamp (thirst - drink, 0, MAX_THIRST);
		
		if (thirst == 0) {
			thirst_delay += THIRST_DELAY_INCREASE;
		} else {
			thirst_delay += (THIRST_DELAY_INCREASE / 2);
		}
	}


	/// <summary>
	/// Returns how full the player is.
	/// </summary>
	public string GetHungerPercent() {
		return ((int)(100 - (hunger / MAX_HUNGER * 100))).ToString();
	}

	/// <summary>
	/// Returns how not-thirsty the player is.
	/// </summary>
	public string GetThirstPercent() {
		return ((int)(100 - (thirst / MAX_THIRST * 100))).ToString();
	}

	/// <summary>
	/// Is player alive?
	/// </summary>
	public bool Dead() {
		return (thirst == MAX_THIRST || hunger == MAX_HUNGER);
	}

	 // Happens every once a second.
	public void Update () {
		if (thirst_delay == 0) {
			thirst = Mathf.Clamp ( thirst + (increase_modifier * increase), 0, MAX_THIRST);
		} else {
			thirst_delay = Mathf.Clamp (thirst_delay - 1.0f, 0, MAX_DELAY);
		}
		if (hunger_delay == 0) {
			hunger = Mathf.Clamp (hunger + (increase_modifier * increase), 0, MAX_HUNGER);
		} else {
			hunger_delay = Mathf.Clamp (hunger_delay - 1.0f, 0, MAX_DELAY);
		}
	}
}
