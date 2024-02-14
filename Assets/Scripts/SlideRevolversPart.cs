using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideRevolversPart : MonoBehaviour
{
	public GameObject rptrigger;
	public Vector3 offset = new Vector3(-1, 0, 0);
	public float speed;

	private void Update()
	{
		if (rptrigger.GetComponent<RPtrigger>().finish == false)
		{
			rptrigger.transform.Translate(offset * Time.deltaTime * speed);
		}
	}
}
