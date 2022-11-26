using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Candle : MonoBehaviour
{
	public Image[] lucifers;

	public float timer = 30;
	
	public float numOfLucifers = 4;

	public GameObject canldeLight;
	public GameObject candleLightTop;

	public AudioSource Match;

	private void Update()
	{
		timer -= Time.deltaTime;
		if (Input.GetKeyDown(KeyCode.R) && timer <= 0 && numOfLucifers > 0)
		{
			Match.Play();
			--numOfLucifers;
			StartCoroutine(luciferCountdown());
		}

		if(numOfLucifers == 3)
		{
			Destroy(lucifers[3]);
		}
		if (numOfLucifers == 2)
		{
			Destroy(lucifers[2]);
		}
		if (numOfLucifers == 1)
		{
			Destroy(lucifers[1]);
		}
		if (numOfLucifers == 0)
		{
			Destroy(lucifers[0]);
		}
	}

	IEnumerator luciferCountdown()
	{
		yield return new WaitForSeconds(0);
		canldeLight.SetActive(true);
		candleLightTop.SetActive(true);
		timer = 30;
		yield return new WaitForSeconds(30);
		canldeLight.SetActive(false);
		candleLightTop.SetActive(false);
	}
}
