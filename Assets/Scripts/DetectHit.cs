using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectHit : MonoBehaviour {

	public string opponent;
	public Slider healthbar;
	Animator animator;

	void OnTriggerEnter2D(Collider2D other)
	{

		if(other.gameObject.tag != opponent) return;

		healthbar.value -= 20;

		if(healthbar.value <= 0)
			animator.SetBool("isDead", true);
	}

	void Start ()
	{

		animator = GetComponent<Animator>();

	}
}
