using UnityEngine;
using System.Collections;

public class Items1 :MonoBehaviour {
	public float weight;
	public string itemName;
	bool playerInRange;
	GameObject player;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
		
	}
	
	// Update is called once per frame
	void Update () {
		if(playerInRange){

		}
	}
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
	void DisplayPressToPickUp(){


	}
}
