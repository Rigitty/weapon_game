using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
	public bool isitstopped;
	public GameObject stopmenu;
	public GameObject firstmenu;
	private bool once;

	private void Start()
	{
		StartCoroutine(waittomap());
	}
	private void Update()
	{
		if (Input.GetKey(KeyCode.Mouse0) && once == false)
		{
			Resumegame();
			firstmenu.SetActive(false);
			once = true;
		}
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			if (!isitstopped)
			{
				Stopgame();
				isitstopped = true;
			}
			else
			{
				Resumegame();
				isitstopped = false;
			}
		}
	}
	IEnumerator waittomap()
	{
		yield return new WaitForSeconds(0.05f);
		Time.timeScale = 0f;
	}

	public void retry()
	{
		SceneManager.LoadScene("SampleScene");
	}

	public void exit()
	{
		Application.Quit();
	}

	public void SetFullscreen(bool fullscreen)
	{
		Screen.fullScreen = fullscreen;
	}

	public void mousesens(float value)
	{
		GameObject.FindGameObjectWithTag("Player").GetComponent<GunController>().sens = value;
	}

	public void Stopgame()
	{
		stopmenu.SetActive(true);
		Cursor.visible = true;
		Time.timeScale = 0f;
		Cursor.lockState = CursorLockMode.None;
	}
	public void Resumegame()
	{
		stopmenu.SetActive(false);
		Cursor.visible = false;
		Time.timeScale = 1f;
		Cursor.lockState = CursorLockMode.Locked;
	}
}
