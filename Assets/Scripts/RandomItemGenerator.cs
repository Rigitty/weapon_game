using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class RandomItemGenerator : MonoBehaviour
{
	public int ranitem;
	public GameObject[] items;
	private void Awake()
	{
		ranitem = Random.Range(0, 4);
		items[ranitem].SetActive(true);
	}
}
