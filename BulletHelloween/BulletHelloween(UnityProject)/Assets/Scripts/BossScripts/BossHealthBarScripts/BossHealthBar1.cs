﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BossHealthBar1 : MonoBehaviour
{
	//VARIABLES                                 //VARIABLES
	[Header("General Variables")]               //GENERAL VARIABLES
	public GameObject bossHUD;                  //Boss HUD
	public GameObject bossObject;               //Boss
	public GameObject player;                   //Player
	public bool barOn = false;                  //Health bar on: true or false
	public float timer;                         //Timer
												//START FUNCTION
	void Start()
	{
		bossHUD.GetComponent<Canvas>().enabled = false;
		bossObject.GetComponent<BossAI1>().bulletLifetime = 0f;
	}
	//UDPATE FUNCTION
	void Update()
	{
		if (barOn == true)
		{
			timer += Time.deltaTime;
			if (timer > 1.5f)
				GetComponent<EdgeCollider2D>().isTrigger = false;
		}
	}
	//TRIGGER FUNCTION
	void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Player" && barOn == false)
		{
			player.GetComponent<PlayerShoot>().shootDelay = 0.3f;
			barOn = true;
			bossHUD.GetComponent<Canvas>().enabled = true;
			bossObject.GetComponent<BossAI1>().bossActive = true;
			bossObject.GetComponent<BossAI1>().bulletLifetime = 10f;
		}
		else if (collision.gameObject.tag == "Player" && barOn == true)
		{
			barOn = false;
			bossHUD.GetComponent<Canvas>().enabled = false;
			bossObject.GetComponent<BossAI1>().bossActive = false;
			bossObject.GetComponent<BossAI1>().bulletLifetime = 0f;
		}
	}
}
///END OF SCRIPT!