using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunsYear : MonoBehaviour
{
	public int damage = 1;
	private int year;
	public GameObject cstatus;
	public GameObject[] guns;
	private int i = 0;
	private bool workonce, workonce1, workonce2;

	private void Update()
	{
		year = cstatus.GetComponent<CurrentStatus>().year;
		if(year >= 1930 && workonce == false)
		{
			guns[i].SetActive(false);
			i++;
			guns[i].SetActive(true);
			workonce = true;
			damage = 2;
		}
		if (year >= 1970 && workonce1 == false)
		{
			guns[i].SetActive(false);
			i++;
			guns[i].SetActive(true);
			workonce1 = true;
			damage = 3;
		}
		if (year >= 2000 && workonce2 == false)
		{
			guns[i].SetActive(false);
			i++;
			guns[i].SetActive(true);
			workonce2 = true;
			damage = 4;
		}
	}
}
