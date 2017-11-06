using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;
	public int minBoundary;
	public int maxBoundary;

	void Update ()
	{
		Vector3 position = transform.position;
		float newPos = player.transform.position.x + 20f;
		if(newPos > minBoundary && newPos < maxBoundary)
		{
			position.x = player.transform.position.x + 20f;
			transform.position = position;
		}
		else
		{
			return;
		}
	}
}
