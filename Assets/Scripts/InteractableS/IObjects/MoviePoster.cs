﻿using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class MoviePoster : MonoBehaviour
{
    public GameObject Answer_A;
    //this is where you reference the TMP element in the UI where you want your text to load
    public TMP_Text interactText;

    private int currentLine;

    private string[] Lines;
    
    private SpriteRenderer sprite;

    private bool interact;
   
    void Start()
    {
        interact = false;
        
        //set idle
        currentLine = -1;
        
        //write lines for this marker here
        Lines = new string[6]; //or however many lines you want this interaction to have

        Lines[0] = "God, Stacy Starbright is so cool.";
        Lines[1] = "Imagine having your awesomeness immortalized forever on a poster.";
        Lines[2] = "Stacey Starbright’s never gonna wake up feeling halfway between life and death, or worrying about school.";
        Lines[3] = "She’s just gonna keep rocking out in the cosmos, fighting dork ass space pirates and looking rad as fuck.";
        Lines[4] = "Sigh…";
        Lines[5] = " ";

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
            sprite.color = new Color(1, 1, 1, 0);
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