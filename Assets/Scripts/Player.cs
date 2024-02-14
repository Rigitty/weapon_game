using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
	public float speed;
	public bool isitalive = true;
	private void Update()
	{
		transform.Translate(Vector3.forward * Time.deltaTime * speed);
	}
}
