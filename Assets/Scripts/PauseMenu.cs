using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
	public GameObject CanvasPM;

	public static bool GameIsPaused = false;

	public AudioSource BGMusic;

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (GameIsPaused)
			{
				Resume();
			}
			else
			{
				Pause();
			}
		}
	}

	public void Resume()
	{
		CanvasPM.SetActive(false);
		Time.timeScale = 1f;
		GameIsPaused = false;
		BGMusic.Play();
	}

	void Pause()
	{
		CanvasPM.SetActive(true);
		Time.timeScale = 0f;
		GameIsPaused = true;
		BGMusic.Pause();
	}

	public void ReturnMainMenu()
	{
		CanvasPM.SetActive(false);
		Time.timeScale = 1f;
		GameIsPaused = false;
	}
}
