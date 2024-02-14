using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	private float timer = 0;
	public float spawntime;
	public GameObject arrow;

	private void Update()
	{
		timer = timer + Time.deltaTime;
		if(spawntime < timer)
		{
			Instantiate(arrow, transform.position, transform.rotation);
			timer = 0;
		}
	}
}
