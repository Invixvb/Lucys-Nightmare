using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VCamSwitch : MonoBehaviour
{
	public GameObject VCamNormal1;
	public GameObject VCamNormal2;
	public GameObject VCamNormal3;

	public GameObject VCamCandle1;
	public GameObject VCamCandle2;
	public GameObject VCamCandle3;

	private void Start()
	{
		StartCoroutine(SwitchAfterTime());
	}

	IEnumerator SwitchAfterTime()
	{
		yield return new WaitForSeconds(150);
		VCamNormal1.SetActive(false);
		VCamNormal2.SetActive(false);
		VCamNormal3.SetActive(false);
		VCamCandle1.SetActive(true);
		VCamCandle2.SetActive(true);
		VCamCandle3.SetActive(true);
	}
}
