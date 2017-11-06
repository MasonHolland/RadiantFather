using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;

	private Rigidbody2D rb2d;
	private Animator animator;

	void Start()
	{
		rb2d = GetComponent<Rigidbody2D> ();
		animator = GetComponent<Animator> ();
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		Vector2 movement = new Vector2 (moveHorizontal, 0f);
		rb2d.MovePosition(rb2d.position + movement * speed);
	}

	void Update ()
	{
		if(Input.GetKeyUp(KeyCode.Space))
		{
			animator.SetBool("isAttacking", true);
		}
		else
		{
			animator.SetBool("isAttacking", false);
		}

		if(Input.GetKey(KeyCode.RightArrow))
			{
				animator.SetBool("isWalking", true);
			}
		else
			{
				animator.SetBool("isWalking", false);
			}
	}
}
