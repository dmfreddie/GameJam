﻿using UnityEngine;
using System.Collections;

public class AIBase : MonoBehaviour {

	[SerializeField]
	protected float hp = 100;
	[SerializeField]
	protected float speed;
	[SerializeField]
	protected float damage;
	[SerializeField]
	protected bool flying;
	protected GameObject currentTarget;
	public GameObject inspectorOverrideTarget;
	[SerializeField]
	protected int goldDrop;
	protected GameManager game;

	// Use this for initialization
	public virtual void Start () 
	{
		game = GameObject.FindObjectOfType<GameManager> ();
	}

	public virtual void Update()
	{
		if (hp <= 0)
			Die ();

		if (currentTarget != null) {
			if (currentTarget != inspectorOverrideTarget)
				currentTarget = inspectorOverrideTarget;
		}
	}

	public virtual void Attack()
	{
	}

	public virtual void Die()
	{
		game.AddGold (goldDrop);
		Destroy (gameObject);
	}

	public virtual void SwitchTarget(GameObject newTarget)
	{
		currentTarget = newTarget;
	}

	public virtual void ApplyDamage(float damageAmount)
	{
		hp -= damageAmount;
	}

}
