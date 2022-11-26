using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GodMode : MonoBehaviour
{
	public GameObject player;
	public GameObject playerCandle;
	public GameObject canvas;

	public GameObject lightHal;
	public GameObject lightWoon;
	public GameObject lightKitchen;

	public GameObject VCamNormal1;
	public GameObject VCamNormal2;
	public GameObject VCamNormal3;

	public GameObject VCamCandle1;
	public GameObject VCamCandle2;
	public GameObject VCamCandle3;

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.I))
		{
			player.SetActive(false);
			playerCandle.transform.position = player.transform.position;
			playerCandle.SetActive(true);
			canvas.SetActive(true);
			lightHal.SetActive(false);
			lightWoon.SetActive(false);
			lightKitchen.SetActive(false);
			VCamNormal1.SetActive(false);
			VCamNormal2.SetActive(false);
			VCamNormal3.SetActive(false);
			VCamCandle1.SetActive(true);
			VCamCandle2.SetActive(true);
			VCamCandle3.SetActive(true);
		}

		if (Input.GetKeyDown(KeyCode.O))
		{
			SceneManager.LoadScene("Win");
		}

		if (Input.GetKeyDown(KeyCode.P))
		{
			SceneManager.LoadScene("Death");
		}
	}
}
