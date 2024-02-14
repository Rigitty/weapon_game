using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedChangers : MonoBehaviour
{
	public bool isitgreen;
	private float defspeed;
	private GameObject player;

	private void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player");
	}

	private void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
		{
			defspeed = player.GetComponent<Player>().speed;
			if (isitgreen)
			{
				other.GetComponent<Player>().speed = defspeed * 1.5f;
			}
			else
			{
				other.GetComponent<Player>().speed = defspeed / 1.5f;
			}
		}
	}
	private void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player")
		{
			other.GetComponent<Player>().speed = defspeed;
		}
	}
}
