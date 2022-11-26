using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wayToLose : MonoBehaviour
{
    private void Update()
    {
        if(gameObject.transform.position.z < 99)
        {
            SceneManager.LoadScene("Death");
        }
    }
}
