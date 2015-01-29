using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {
	public float timeBetweenAttacks = 0.5f;
	public int attackDamage = 10;
	private GameObject playerdb_object;
	private PlayerDatabase playerdb;
	Animator anim;
	GameObject player;
	bool playerInRange;
	float timer;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
		anim = GetComponent<Animator> ();
		playerdb_object = GameObject.Find ("PlayerDB");	
		playerdb = playerdb_object.GetComponent<PlayerDatabase>();
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
		if (!playerdb.playerAlive) {
			anim.SetTrigger("PlayerDead");		
		}
	}

	void Attack(){
		timer = 0;
		if (playerdb.playerAlive) {
			playerdb.health.TakeDamage(attackDamage);		
		}

	}
}
