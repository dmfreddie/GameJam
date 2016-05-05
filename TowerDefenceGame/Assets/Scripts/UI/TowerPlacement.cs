﻿using UnityEngine;
using System.Collections;

public class TowerPlacement : MonoBehaviour {

	public bool isTrue = false;

	GameObject panel;
	
	void Start()
	{
		panel = GameObject.FindGameObjectWithTag ("TowerSelect");
	}

	void Update()
	{
		if (isTrue) 
		{
			panel.SetActive (true);
		} 
		else 
		{
			panel.SetActive(false);
		}

	}

	public void Placement()
	{
		isTrue = !isTrue;

	}
}
