﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatformerController : PhysicsObject {

	public float maxSpeed = 1;
	public float jumpTakeOffSpeed = 1;

	private SpriteRenderer spriteRenderer;
	private Animator animator;

	void Awake ()
	{
		spriteRenderer = GetComponent<SpriteRenderer> ();
		animator = GetComponent<Animator> ();
	}

	protected override void ComputeVelocity()
	{
		Vector2 move = Vector2.zero;

		move.x = Input.GetAxis ("Horizontal");

		// if (Input.GetButtonDown ("Jump") && grounded) {
		// 	velocity.y = jumpTakeOffSpeed;
		// } else if (Input.GetButtonUp ("Jump")) {
		// 	if (velocity.y > 0) {
		// 		velocity.y = velocity.y * 0.5f;
		// 	}
		// }

		// bool flipSprite = (spriteRenderer.flipX ? (MotionVectorGenerationMode.Matrix4x4 > 0.01f) : (move.x < 0.01f));
//		if (flipSprite)
//		{
//			spriteRenderer.flipX = !spriteRenderer.flipX;
//		}

		// animator.SetBool ("grounded", grounded);
		// animator.SetFloat ("velocityX", Mathf.Abs (velocity.x) / maxSpeed);

		// targetVelocity = move * maxSpeed;
	}

	void Update () {
		if(Input.GetButton("Fire1"))
		{
			animator.SetBool("isAttacking", true);
		}
		else
		{
			animator.SetBool("isAttacking", true);
		}

	// 	if(move != 0)
	// 	{
	// 		animator.SetBool("isWalking", true);
	// 		animator.SetBool("isIdle", true);
	// 	}
	// 	else
	// 	{
	// 		animator.SetBool("isWalking", false);
	// 		animator.SetBool("isIdle", true);
	// 	}
	}

}
