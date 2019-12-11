using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bedroom_Door : MonoBehaviour
{

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                PlayerPrefs.SetInt("Scene", 2);
                SceneManager.LoadScene("Scenes/HallwayScene");
            }
        }
    }
}
