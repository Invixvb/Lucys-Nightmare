using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
	public void playGame()
	{
		SceneManager.LoadScene("IntroScene 1");
	}

	public void quitGame()
	{
		Application.Quit();
		print("Quit");
	}

	public void loadIntroScene2()
	{
		SceneManager.LoadScene("IntroScene 2");
	}

	public void loadIntroScene3()
	{
		SceneManager.LoadScene("IntroScene 3");
	}

	public void playActualGame()
	{
		SceneManager.LoadScene("SampleScene");
	}

	public void loadMainMenu()
	{
		SceneManager.LoadScene("MainMenu");
	}
}
