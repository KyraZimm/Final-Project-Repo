using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hallway_Door_3 : MonoBehaviour
{
    public TMP_Text interactText;
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (PlayerPrefs.GetInt("Scene") == 5)
                {
                    PlayerPrefs.SetInt("LastDoorUsed", 3);
                    SceneManager.LoadScene("Scenes/JennyBedroom");
                }
                else
                {
                    interactText.text = "...I have better things to do.";
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            interactText.text = "";
        }
    }
}
