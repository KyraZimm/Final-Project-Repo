using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hallway_Door_2 : MonoBehaviour
{
    
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                PlayerPrefs.SetInt("LastDoorUsed", 2);
                SceneManager.LoadScene("Scenes/MessHall");
            }
        }
    }
}
