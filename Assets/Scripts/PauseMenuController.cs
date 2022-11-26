using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuController : MonoBehaviour
{
	public void loadMainMenu()
	{
		SceneManager.LoadScene("MainMenu");
	}

	public void quitGame()
	{
		Application.Quit();
		print("Quit");
	}
}