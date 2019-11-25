using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bedroom_Door : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("trigger recognized");
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("player recognized");
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("space pressed");
                SceneManager.LoadScene(1);
            }
        }
    }
}
