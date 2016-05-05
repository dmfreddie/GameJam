﻿using UnityEngine;
using System.Collections;

public class Magic : MonoBehaviour {

	Pointer point;

	TowerPlacement towers;

	GameObject tile;

	bool mage = false;

	// Use this for initialization
	void Start () {

		towers = GameObject.FindObjectOfType<TowerPlacement> ();
		point = GameObject.FindObjectOfType<Pointer> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (mage && !towers.isTrue)
			point.placeTower = false;

		if (point.placeTower) 
		{
			tile = point.currentTile;
			//GameObject go = Instantiate (Resources.Load ("Prefabs/Towers/" + index.ToString ()), tile.transform.position, tile.transform.rotation) as GameObject;
			
			if (Input.GetAxis ("TriggerSelectRight") < 1) 
			{
				//Destroy(go);
			}
		} 
		else 
		{
			tile = null;
		}
		
		if (mage && point.placeTower && Input.GetAxis ("TriggerSelectRight") >= 1) 
		{
			
			if(tile.GetComponent<NodePath>().pathType == NodePath.PathType.Grass && !tile.GetComponent<NodePath>().towerPlaced)
			{
				Instantiate (Resources.Load("Prefabs/Towers/Magic"), tile.transform.position, tile.transform.rotation);
				tile.GetComponent<NodePath>().towerPlaced = true;
			}
		}
	}

	public void PlaceMagic()
	{
		point.placeTower = !point.placeTower;
		mage = !mage;
	}
}