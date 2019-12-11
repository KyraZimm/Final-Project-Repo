using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class Guitar : MonoBehaviour
{
    public GameObject Answer_A;
    //this is where you reference the TMP element in the UI where you want your text to load
    public TMP_Text interactText;

    private int currentLine;

    private string[] Lines;
    
    private bool interact;
   
    void Start()
    {
        interact = false;
        
        //set idle
        currentLine = -1;
        
        //write lines for this marker here
        Lines = new string[3]; //or however many lines you want this interaction to have

        Lines[0] = "I’m so flaky. I say to myself that I want to learn music, then I buy a guitar before I’ve given it a second thought.";
        Lines[1] = "When was the last time I touched this? May? Of what year?";
        Lines[2] = " ";

    }

    private void Update()
    {
        if (interact)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Answer_A.SetActive(true);
                UpdateText();
            }
        }
        
        if (currentLine > Lines.Length)
        {
            interactText.text = " ";
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            //I found that flipping a bool here and then referencing it in updates glitches less
            
            interact = true;
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        interact = false;
        interactText.text = " ";
    }

    private void UpdateText()
    {
        var nextLine = currentLine + 1;

        interactText.text = Lines[nextLine];

        currentLine = nextLine;
    }
}