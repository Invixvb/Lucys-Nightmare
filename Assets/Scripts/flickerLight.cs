using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class flickerLight : MonoBehaviour
{
	public GameObject lightHal;
	public GameObject lightWoon;
	public GameObject lightKitchen;

	float waitSecLight1;

	float waitSecLight2;

	private void Start()
	{
		StartCoroutine(flickerLightCo());
		StartCoroutine(lightsOffAfterTimeCo());
	}
	
	public IEnumerator flickerLightCo()
	{
		waitSecLight1 = Random.Range(0.25f, 1.5f);
		waitSecLight2 = Random.Range(0.1f, 1.25f);

		yield return new WaitForSeconds(waitSecLight1);
		lightHal.SetActive(false);
		lightWoon.SetActive(false);
		lightKitchen.SetActive(false);
		yield return new WaitForSeconds(waitSecLight2);
		lightHal.SetActive(true);
		lightWoon.SetActive(true);
		lightKitchen.SetActive(true);

		StartCoroutine(flickerLightCo());
	}

	IEnumerator lightsOffAfterTimeCo()
	{
		yield return new WaitForSeconds(150);
		StopAllCoroutines();
		lightHal.SetActive(false);
		lightWoon.SetActive(false);
		lightKitchen.SetActive(false);
	}
}
