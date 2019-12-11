using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Kitchen_TryAgainMarker : MonoBehaviour
{

    public bool TryAgain;
    public TMP_Text interactText;
    private BoxCollider2D collider;
   
    void Start()
    {
        TryAgain = false;
        
        collider = GetComponent<BoxCollider2D>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (TryAgain)
            {
                interactText.text = "...You can do this, Carey. Just go back and try talking to her again.";
                TryAgain = false;
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
