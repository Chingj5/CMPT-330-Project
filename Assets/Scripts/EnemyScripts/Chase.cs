using UnityEngine;
using System.Collections;

public class Chase : MonoBehaviour {
	Transform player;
	// Use this for initialization
	NavMeshAgent nav;

	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		nav = GetComponent<NavMeshAgent> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		nav.SetDestination (player.position);
	}
}
