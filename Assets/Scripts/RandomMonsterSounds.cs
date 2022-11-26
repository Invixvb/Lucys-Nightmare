using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMonsterSounds : MonoBehaviour
{
    [SerializeField]int waitSec1;
    public AudioSource Roar1;

    
    [SerializeField]int waitSec2;
    public AudioSource Roar2;

    void Start()
    {
        StartCoroutine(RandomRoar());
        StartCoroutine(RandomRoar2());
    }

    IEnumerator RandomRoar()
	{
        waitSec1 = Random.Range(20, 70);
        yield return new WaitForSeconds(waitSec1);
        Roar1.Play();
        StartCoroutine(RandomRoar());
    }

    IEnumerator RandomRoar2()
    {
        waitSec2 = Random.Range(60, 120);
        yield return new WaitForSeconds(waitSec2);
        Roar2.Play();
        StartCoroutine(RandomRoar2());
    }
}
