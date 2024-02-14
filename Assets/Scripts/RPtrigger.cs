using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPtrigger : MonoBehaviour
{
	public Vector3 offset = new Vector3(-1, 0, 0);
	public bool finish;
	public float speed;
	public int bulletcount;
	public GameObject revolverchild;
	private int rand;
	private void Awake()
	{
		rand = Random.Range(0, 5);
		transform.Translate(new Vector3(rand, 0, 0));
	}

	private void Update()
	{
		bulletcount = revolverchild.GetComponent<RevolversPart>().bulletcount;
		if(finish)
		{
			transform.Translate(offset * Time.deltaTime * speed);
		}
	}
	private void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("Player"))
		{
			finish = true;
		}
	}
}
