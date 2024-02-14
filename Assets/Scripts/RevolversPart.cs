using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevolversPart : MonoBehaviour
{
	public int bulletcount = 0;
	public Vector3 offset = new Vector3(-1, 0, 0);
	public AudioClip reload;
	private void Update()
	{
		GetComponent<Animator>().SetInteger("bulletcount", bulletcount);
	}

	private void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("bullet"))
		{
			bulletcount++;
			Camera.main.GetComponent<AudioSource>().PlayOneShot(reload);
			Destroy(other.gameObject);
		}
	}
}
