using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ThingGenerator : MonoBehaviour
{
	public int isiton;
	public int	value;
	public int	change; // 0-range 1-year 2-firerate
	public GameObject[] side;
	public GameObject cstatus;
	public GameObject range;
	private float fvalue;
	public GameObject scexe;
	private void	Awake()
	{
		scexe = GameObject.FindGameObjectWithTag("scexe");
		isiton = Random.Range(0, 10);
		if(isiton < 4)
		{
			Destroy(gameObject);
		}
		value = Random.Range(-10, 10);
		while (value == 0)
		{
			value = Random.Range(-10, 10);
		}
		change = Random.Range(0,3);
	}
	private void Update()
	{
		ChangeActives(value, change, side);
	}

	private void ChangeActives(int	value, int	change, GameObject[]	side)
	{
		if(value > 0)
		{
			side[0].SetActive(true);
			side[1].SetActive(false);
			side[2].GetComponent<TextMeshPro>().text = value.ToString();
			if(change == 0)
			{
				side[3].SetActive(true);
			}
			if (change == 1)
			{
				side[4].SetActive(true);
			}
			if (change == 2)
			{
				side[5].SetActive(true);
			}
		}
		else
		{
			side[0].SetActive(false);
			side[1].SetActive(true);
			side[2].GetComponent<TextMeshPro>().text = value.ToString();
			if (change == 0)
			{
				side[3].SetActive(true);
			}
			if (change == 1)
			{
				side[4].SetActive(true);
			}
			if (change == 2)
			{
				side[5].SetActive(true);
			}
		}
	}
	private void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("bullet"))
		{
			value = value + scexe.GetComponent<GunsYear>().damage;
			Destroy(other.gameObject);
		}
		if(other.CompareTag("Player"))
		{
			if (change == 0)
			{
				cstatus.GetComponent<CurrentStatus>().range = cstatus.GetComponent<CurrentStatus>().range + value;
				range.GetComponent<Range>().postpone(cstatus.GetComponent<CurrentStatus>().range);
			}
			if (change == 1)
			{
				cstatus.GetComponent<CurrentStatus>().year = Mathf.Clamp(cstatus.GetComponent<CurrentStatus>().year + value*5,1880, 2024);
				cstatus.GetComponent<CurrentStatus>().range = cstatus.GetComponent<CurrentStatus>().range + value + (cstatus.GetComponent<CurrentStatus>().year - 1800) / 5;
				range.GetComponent<Range>().postpone(cstatus.GetComponent<CurrentStatus>().range);
				fvalue = value + (cstatus.GetComponent<CurrentStatus>().year - 1800) / 5;
				fvalue = value;
				fvalue = fvalue / 100;
				fvalue = Mathf.Clamp(fvalue, 0.01f, 0.95f);
				if (cstatus.GetComponent<CurrentStatus>().firerate > 0.05f)
					cstatus.GetComponent<CurrentStatus>().firerate = cstatus.GetComponent<CurrentStatus>().firerate - fvalue;
			}
			if (change == 2)
			{
				fvalue = value;
				fvalue = fvalue / 100;
				fvalue = Mathf.Clamp(fvalue, 0.01f, 0.95f);
				if (cstatus.GetComponent<CurrentStatus>().firerate > 0.05f)
						cstatus.GetComponent<CurrentStatus>().firerate = cstatus.GetComponent<CurrentStatus>().firerate - fvalue;
			}
		}
	}
}
