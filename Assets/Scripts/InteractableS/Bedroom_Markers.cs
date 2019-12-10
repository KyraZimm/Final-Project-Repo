using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bedroom_Markers : MonoBehaviour
{

    private SpriteRenderer sprite;
    
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {
        if (PlayerPrefs.GetInt("Scene") == 1)
        {
            sprite.color = new Color(1, 1, 1, 1);
        }
        else
        {
            sprite.color = new Color(1, 1, 1, 0);
        }
    }
}
