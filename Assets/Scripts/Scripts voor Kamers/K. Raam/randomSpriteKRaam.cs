using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomSpriteKRaam : MonoBehaviour
{
    public GameObject Monster;

    public int waitSec;

    public GameObject[] m_gameObjects;

    public int Window;

    public GameObject Sprite1;
    public GameObject Sprite2;
    public GameObject Sprite3;

    public AudioSource KRaam;


    private void Start()
    {
        StartCoroutine(coroutineRandomColor());
    }

    private void Update()
    {
        m_gameObjects = new GameObject[transform.childCount];
        m_gameObjects = GameObject.FindGameObjectsWithTag("Window K");
    }

    IEnumerator coroutineRandomColor()
    {
        waitSec = Random.Range(20, 45);
        yield return new WaitForSeconds(waitSec);
        Window = Random.Range(0, m_gameObjects.Length);
        if (Sprite2.activeSelf == true)
        {
            Sprite2.SetActive(false);
            Sprite3.SetActive(true);
            print("Sprite3 Enabled/Dood");
            Monster.transform.position = new Vector3(Monster.transform.position.x, Monster.transform.position.y, 98f);
        }
        if (Sprite1.activeSelf == true)
        {
            Sprite1.SetActive(false);
            Sprite2.SetActive(true);
            print("Sprite2 Enabled");
            KRaam.Play();
        }
        StartCoroutine(coroutineRandomColor());
    }
}
