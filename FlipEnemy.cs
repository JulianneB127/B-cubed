using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipEnemy
{
	void OnTriggerEnter2D(collider2D Enemy)
	{
		if (Enemy.tag == "Enemy")
		{
			Enemy.transform.Rotate(0f, 180f, 0f);
		}
	}
}
//place on edges of enemy patrol area
