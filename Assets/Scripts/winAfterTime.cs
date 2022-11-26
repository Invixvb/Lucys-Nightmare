using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winAfterTime : MonoBehaviour
{   
    void Start()
    {
        StartCoroutine(coroutine());
    }

    private IEnumerator coroutine()
	{
        yield return new WaitForSeconds(301);
        SceneManager.LoadScene("Win");
    }
}
