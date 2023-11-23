using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehavior
{
	public int LifeTotoal = 1;
	public int EnemySpeed = 20;
	public Rigidbody rb;
	
	void Start()
	{
		rb = gameObjects.GetComponents<RigidBody2D>();
	}

	void Update()
	{
		rb.velocity = transform.right * EnemySpeed;
	}
	//must add rigid body and capsule collider to enemy sprit in developer

}
