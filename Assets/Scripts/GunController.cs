using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GunController : MonoBehaviour
{
	public	float				sens;
	public	float				maxposx, minposx;

	private void Update()
	{
		if (GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().isitalive == true)
		{
			Vector3 mouseinput = Input.GetAxis("Mouse X") * Time.deltaTime * sens * transform.right;
			if (transform.position.x > maxposx)
			{
				transform.position = new Vector3(maxposx, transform.position.y, transform.position.z);
			}
			if (transform.position.x < minposx)
			{
				transform.position = new Vector3(minposx, transform.position.y, transform.position.z);
			}
			else
			{
				transform.Translate(mouseinput);
			}
		}
	}
}
