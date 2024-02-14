using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Pistol : MonoBehaviour
{
	public float	firerate;
	private float	timer;
	public	GameObject	bullet;
	public	GameObject	shootpoint;
	public GameObject player;
	public GameObject currentstatus;
	public GameObject year;

	private void Update()
	{	
		if (GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().isitalive == true)
		{
			firerate = currentstatus.GetComponent<CurrentStatus>().firerate;
			if (timer > firerate)
			{
				timer = 0;
				Instantiate(bullet, shootpoint.transform.position, Quaternion.identity);
				player.GetComponent<Animator>().SetTrigger("trigger");
			}
			else
			{
				timer = timer + Time.deltaTime;
			}

			year.GetComponent<TextMeshPro>().text = currentstatus.GetComponent<CurrentStatus>().year.ToString();
		}
	}
}
