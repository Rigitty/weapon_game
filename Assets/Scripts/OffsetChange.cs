using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffsetChange : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("revolverpart"))
		{
			other.GetComponent<RPtrigger>().offset = new Vector3(0, 0, 1);
		}
	}
}
