using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class EnemyHealth : MonoBehaviour {
	public int startingHealth = 100;
	public int currentHealth;



	public float flashSpeed=5f;
	public Color flashColour=new Color(1f,0f,0f,0.1f);
	Animator anim;
	AudioSource enemyAudio;
	CapsuleCollider capsuleCollider;
	bool isDead;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
