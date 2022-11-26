using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AfterSecDisableDeathScreen : MonoBehaviour
{
	public GameObject Menu;

	private void Start()
	{
		StartCoroutine(afterSecDisable());
	}

	IEnumerator afterSecDisable()
	{
		yield return new WaitForSeconds(3.5f);
		gameObject.SetActive(false);
		Menu.SetActive(true);
	}
}
