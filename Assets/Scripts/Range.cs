using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Range : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		if(other.tag == "bullet")
		{
			Destroy(other.gameObject);
		}
	}
	public void postpone(int range)
	{
		int a;
		a = Mathf.Clamp(range, 3, 100);
		transform.Translate(0, 0, a/10);
	}
}
