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
    
    private SpriteRenderer sprite;

    private bool interact;
   
    void Start()
    {
        interact = false;

        //set idle
        currentLine = -1;
        
        //write lines for this marker here
        Lines = new string[6]; //or however many lines you want this interaction to have

        Lines[0] = "I remember building this model spaceship. took me like, a whole week.";
        Lines[1] = "You know what? I think I’d do amazingly on a spaceship.";
        Lines[2] = "I’m good under tough, pressure situations like that.";
        Lines[3] = "Shields down? No problem. Airlock broken? I got it. Morale lost? Not with me around.";
        Lines[4] = "Yeah, I’d be a great captain.";
        Lines[5] = " ";

    }

    private void Update()
    {
        if (interact)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
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