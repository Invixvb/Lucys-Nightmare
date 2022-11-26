using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkScriptCandle : MonoBehaviour
{
	public float speed;

	public float positiveFlip = 1f;
	public float negativeFlip = 1f;

	public Animator anim;

	private void Update()
	{
		transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0f, 0f);

		if(Input.GetAxis("Horizontal") != 0)
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
}
