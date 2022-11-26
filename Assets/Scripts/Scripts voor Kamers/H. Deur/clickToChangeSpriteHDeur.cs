using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickToChangeSpriteHDeur : MonoBehaviour
{
    public GameObject SpriteClicked1;
    public GameObject SpriteClicked2;
    public GameObject SpriteClicked3;

    void OnMouseDown()
    {
        print("clicked");
        SpriteClicked1.SetActive(true);
        SpriteClicked2.SetActive(false);
        SpriteClicked3.SetActive(false);
    }
}