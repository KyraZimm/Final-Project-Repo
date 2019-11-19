using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableScript : MonoBehaviour
{

    private bool interact;

    void Start()
    {
        //set initial value
        interact = false;
    }

   
    void Update()
    {
        //allow interaction
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (interact)
            {
                Debug.Log("interaction happens!");
                //create event that occurs
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            interact = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            interact = false;
        }
    }
}
