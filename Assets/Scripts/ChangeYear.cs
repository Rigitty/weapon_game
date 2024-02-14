using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeYear : MonoBehaviour
{
	public int value;
	public GameObject cstatus;
	public GameObject range;
	private float fvalue;
	public GameObject valuetext;

	private void Start()
	{
		valuetext.GetComponent<TextMeshPro>().text = value.ToString();
	}
	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
				cstatus.GetComponent<CurrentStatus>().year = Mathf.Clamp(cstatus.GetComponent<CurrentStatus>().year + value * 5, 1880, 2024);
				cstatus.GetComponent<CurrentStatus>().range = cstatus.GetComponent<CurrentStatus>().range + value + (cstatus.GetComponent<CurrentStatus>().year - 1800) / 5;
				range.GetComponent<Range>().postpone(cstatus.GetComponent<CurrentStatus>().range);
				fvalue = value + (cstatus.GetComponent<CurrentStatus>().year - 1800) / 5;
				fvalue = -(fvalue / 70);
				fvalue = Mathf.Clamp(fvalue, 0.07f, 2);
				cstatus.GetComponent<CurrentStatus>().firerate = cstatus.GetComponent<CurrentStatus>().firerate + fvalue;
		}
	}
}
