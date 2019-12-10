using System.Collections;
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
            transform.position = new Vector2(-30, 11.9f);
        }
    }
}
