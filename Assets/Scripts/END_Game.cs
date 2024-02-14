using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class END_Game : MonoBehaviour
{
	public GameObject winmenu;
	private void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("Player"))
		{
			winmenu.SetActive(true);
			other.GetComponent<Player>().isitalive = false;
			other.GetComponent<Player>().speed = 0;
			other.GetComponent<Animator>().SetTrigger("Win");
		}
	}
}
