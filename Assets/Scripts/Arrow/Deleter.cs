using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deleter : MonoBehaviour
{
	public int ammocounter = 0;
	public GameObject[] ammos;
	private int i;
	public GameObject side1, side2, side3;
	private void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("arrow"))
		{
			Destroy(other.gameObject);
		}
		if (other.CompareTag("revolverpart"))
		{
			i = ammocounter;
			ammocounter = other.GetComponent<RPtrigger>().bulletcount + ammocounter;
			other.GetComponent<RPtrigger>().offset = new Vector3(0, -1, 0);
			if (ammocounter <=12)
				StartCoroutine(spawndelay(i, ammocounter));
			StartCoroutine(waittodelete(other));
		}
		IEnumerator spawndelay(int i, int ammocounter)
		{
			yield return new WaitForSeconds(0.25f);
			ammos[i].SetActive(true);
			i++;
			if(i < ammocounter)
			{
				if (i >= 3)
				{
					side1.SetActive(true);
				}
				if (i >= 7)
				{
					side2.SetActive(true);
				}
				if (i >= 11)
				{
					side3.SetActive(true);
				}
				StartCoroutine(spawndelay(i, ammocounter));
			}
		}

		IEnumerator waittodelete(Collider a)
		{
			yield return new WaitForSeconds(1f);
			Destroy(a.gameObject);
		}
	}
}
