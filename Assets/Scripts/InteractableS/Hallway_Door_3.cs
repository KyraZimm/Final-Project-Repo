using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hallway_Door_3 : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (PlayerPrefs.GetInt("Scene") == 5)
                {
                    PlayerPrefs.SetInt("LastDoorUsed", 3);
                }
            }
        }
    }
}
