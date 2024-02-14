using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slidetrigger : MonoBehaviour
{
	public bool isitright;
	public SlideRevolversPart srp;

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("revolverpart"))
		{
			if (isitright)
			{
				srp.offset = new Vector3(-1, 0, 0);
			}
			else
			{ 
				srp.offset = new Vector3(1, 0, 0);
			}
		}
	}
}
