using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class EnemyManager : MonoBehaviour {
	GameObject enemy;
	public float spawnTime = 3f;
	public Transform[] spawnPoints;
	public PlayerHealth playerHealth;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}
	void Spawn(){
		if (playerHealth.currentHealth <= 0f) {
			return;		
		}

		int spawnPointIndex = Random.Range (0, spawnPoints.Length);
		Instantiate (enemy, spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);



	}
	// Update is called once per frame
	void Update () {
	
	}
}
