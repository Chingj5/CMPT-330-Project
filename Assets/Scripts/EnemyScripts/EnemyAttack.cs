﻿using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {
	public float timeBetweenAttacks = 0.5f;
	public int attackDamage = 10;
	Animator anim;
	GameObject player;
	PlayerHealth playerHealth;
	bool playerInRange;
	float timer;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
		playerHealth = player.GetComponent<PlayerHealth> ();
		anim = GetComponent<Animator> ();
	}
	//determines if player is in range of monster
	void OnTriggerEnter(Collider other){
		if (other.gameObject == player) {
			playerInRange = true;
		}
	
	}
	void OnTriggerExit(Collider other){
		if (other.gameObject == player) {
			playerInRange = false;
		}
	
	}
	//--------------------------------------------

	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer >= timeBetweenAttacks && playerInRange) {
			Attack();		
		}
		if (playerHealth.currentHealth <= 0) {
			anim.SetTrigger("PlayerDead");		
		}
	}

	void Attack(){
		timer = 0;
		if (playerHealth.currentHealth > 0) {
			playerHealth.TakeDamage(attackDamage);		
		}

	}
}
