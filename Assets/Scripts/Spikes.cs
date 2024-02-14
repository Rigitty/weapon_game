using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
	private GameObject cstatus;
	private void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("Player"))
		{
			cstatus = GameObject.FindGameObjectWithTag("cstatus");
			cstatus.GetComponent<CurrentStatus>().year = cstatus.GetComponent<CurrentStatus>().year - 15;
			GetComponent<Animator>().SetTrigger("Damage");
		}
	}
}
