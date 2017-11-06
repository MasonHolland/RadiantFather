// ﻿using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
//
// public class EnemyHealth : MonoBehaviour {
//
// 	public int maxHealth = 100;
// 	public int currentHealth = 100;
//
// 	public void AdjustCurrentHealth(int adj)
// 	{
// 		currentHealth += adj;
//
// 		if(currentHealth < 0)
// 		currentHealth = 0;
//
// 		if(currentHealth > maxHealth)
// 		currentHealth = maxHealth;
//
// 		if(maxHealth < 1)
// 		maxHealth = 1;
// 	}
//
// 	void Start ()
// 	{
//
// 	}
//
// 	// Update is called once per frame
// 	void Update ()
// 	{
// 		AdjustCurrentHealth(0);
// 	}
//
// }
