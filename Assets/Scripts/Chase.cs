using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour {

	public int health = 100;

	public Transform player;
	Animator animator;

	void Start ()
	{
		animator = GetComponent<Animator> ();
	}

	void Update ()
	{
		if(Vector2.Distance(player.position, this.transform.position) < 10)
		{
			Vector2 direction = player.position - this.transform.position;

			animator.SetBool("isAlert", true);

			if(direction.magnitude > 5)
			{
				animator.SetBool("isFlying", true);

				this.transform.Translate(-0.05f,0,0);
			}
		}
		if(health <= 0)
		{
			Destroy(gameObject);
		}
		// if(health <= 0) return;
	}
}
