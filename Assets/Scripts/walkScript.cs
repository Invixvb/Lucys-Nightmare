using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkScript : MonoBehaviour
{
	public float speed;

	public float positiveFlip = 0.5f;
	public float negativeFlip = 0.5f;

	public Animator anim;

	public GameObject player;
	public GameObject playerCandle;
	public GameObject canvas;

	private void Start()
	{
		StartCoroutine(playerSwitch());
	}

	private void Update()
	{
		playerCandle.transform.position = player.transform.position;

		transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0f, 0f);

		if (Input.GetAxis("Horizontal") != 0)
		{
			anim.SetBool("isWalking", true);
			GetComponent<AudioSource>().UnPause();
		}
		else
		{
			anim.SetBool("isWalking", false);
			GetComponent<AudioSource>().Pause();
		}

		Vector3 characterScale = transform.localScale;
		if(Input.GetAxis("Horizontal") < 0)
		{
			characterScale.x = negativeFlip;
		}
		if (Input.GetAxis("Horizontal") > 0)
		{
			characterScale.x = positiveFlip;
		}
		transform.localScale = characterScale;
	}

	IEnumerator playerSwitch()
	{
		yield return new WaitForSeconds(150);
		player.SetActive(false);
		playerCandle.transform.position = player.transform.position;
		playerCandle.SetActive(true);
		canvas.SetActive(true);
	}
}
