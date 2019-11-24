using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    //reference UI assets
    public Button ButtonA;
    private TMP_Text ButtonAText;
    public Button ButtonB;
    private TMP_Text ButtonBText;
    public TMP_Text CareyThoughts;
    public TMP_Text RealityDialogue;
    public TMP_Text FantasyDialogue;
    
    
   
    void Start()
    {
        //reference button text
        ButtonAText = ButtonA.GetComponentInChildren<TMP_Text>();
        ButtonBText = ButtonB.GetComponentInChildren<TMP_Text>();
    }

    
    void Update()
    {
        StopOverlappingText();
    }

    void StopOverlappingText()
    {
        //if Carey's thoughts are not blank, hide answer text
        if (CareyThoughts.text != " " && CareyThoughts.text != "")
        {
            ButtonAText.text = " ";
            ButtonBText.text = " ";
        }

        //if answers are not blank, hide Carey's thoughts
        else if (ButtonAText.text != " " && ButtonAText.text != "")
        {
            CareyThoughts.text = " ";
        }
    }
}
