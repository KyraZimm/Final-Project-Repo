using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JennyPosition : MonoBehaviour
{
    void Update()
    {
       
        //object position
        if (PlayerPrefs.GetInt("Scene") == 0)
        {
            transform.position = new Vector2(-2, -13.4f);
        }
        else if (PlayerPrefs.GetInt("Scene") == 2)
        {
            transform.position = new Vector2(-30, -13.4f);
        }
        else if (PlayerPrefs.GetInt("Scene") == 4)
        {
            transform.position = new Vector2(35, -13.4f);
        }
    }
}
