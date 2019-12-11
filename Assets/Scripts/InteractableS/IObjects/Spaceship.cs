using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class Spaceship : MonoBehaviour
{
    //this is where you reference the TMP element in the UI where you want your text to load
    public TMP_Text interactText;

    private int currentLine;

    private string[] Lines;
   
    void Start()
    {
        //set idle
        currentLine = -1;
        
        //write lines for this marker here
        Lines = new string[3]; //or however many lines you want this interaction to have

        Lines[0] = "I think I’d do amazingly on a spaceship.";
        Lines[1] = "I’m good under tough, pressure situations like that.";
        Lines[2] = "Shields down? No problem. Airlock broken? I got it. Morale lost? Not with me around. Yeah, I’d be a great captain.";
    }

    private void Update()
    {
        if (currentLine > Lines.Length)
        {
            interactText.text = " ";
        }
    }


    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == " Player")
        {
            //I found that flipping a bool here and then referencing it in updates glitches less
            if (Input.GetKeyDown(KeyCode.Space))
            {
                UpdateText();
            }
        }
    }

    private void UpdateText()
    {
        var nextLine = currentLine + 1;

        interactText.text = Lines[nextLine];

        currentLine = nextLine;
    }
}