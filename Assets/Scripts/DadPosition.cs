﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DadPosition : MonoBehaviour
{
    void Update()
    {
       
        //object position
        if (PlayerPrefs.GetInt("Scene") == 0)
        {
            transform.position = new Vector2(-2, 11.9f);
        }
        else if (PlayerPrefs.GetInt("Scene") == 2)
        {
            transform.position = new Vector2(-35, 11.9f);
        }
        else if (PlayerPrefs.GetInt("Scene") == 4)
        {
            transform.position = new Vector2(41, 11.9f);
        }
    }
}
