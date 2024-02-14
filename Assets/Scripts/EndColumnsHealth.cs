using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class EndColumnsHealth : MonoBehaviour
{
	public int health;
	public GameObject text;
	public GameObject scexe;
	public GameObject column;
	private void Update()
	{
		text.GetComponent<TextMeshPro>().text = health.ToString();
		if(health <= 0)
		{
			StartCoroutine(destroycolumn());
		}
	}
	IEnumerator destroycolumn()
	{
		column.GetComponent<Animator>().SetTrigger("godown");
		GetComponent<BoxCollider>().enabled = false;
		yield return new WaitForSeconds(1f);
		Destroy(gameObject);
	}
	private void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("bullet"))
		{
			health = health - scexe.GetComponent<GunsYear>().damage;
			Destroy(other.gameObject);
		}
		if(other.CompareTag("Player"))
		{
			if(health > 0)
			{
				other.GetComponent<Player>().speed = 0;
				other.GetComponent<Animator>().SetTrigger("Death");
				other.GetComponent<Player>().isitalive = false;
			}
		}
	}
}
