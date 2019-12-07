using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HallwayDialogue_3 : MonoBehaviour
{
    //"turn on" interactions
    public bool interact;
    
    //load dialogue
    public TextAsset JsonFile;
    public Dialogue dialogue;

    //class for dialogue
    [Serializable]
    public struct Dialogue
    {
        public string[] Responses;
        public string[] AnswerA;
        public string[] AnswerB;
    }
    
    //reference text/UI assets
    public TMP_Text ResponseText;
    public Button AnswerA;
    private TMP_Text ButtonAText;
    public Button AnswerB;
    private TMP_Text ButtonBText;
    
    //store which question/answer set the player is on
    private string thisResponse;
    private string thisAnswerA;
    private string thisAnswerB;


    void Start()
    {
        //unpack JSON
        dialogue = JsonUtility.FromJson<Dialogue>(JsonFile.text);
        
        //reference UI elements
        ButtonAText = AnswerA.GetComponentInChildren<TMP_Text>();
        ButtonBText = AnswerB.GetComponentInChildren<TMP_Text>();
        
        //add listeners to buttons
        AnswerA.onClick.AddListener(ClickedA);
        AnswerB.onClick.AddListener(ClickedB);
        
        //set idle
        interact = false;
        ResponseText.text = " ";
        ButtonAText.text = " ";
        ButtonBText.text = " ";
        
        //assign first set of answers
        thisResponse = dialogue.Responses[0];
        thisAnswerA = dialogue.AnswerA[0];
        thisAnswerB = dialogue.AnswerB[0];

    }
    
    public void AssignDialogueSet(string LastButtonClicked)
    {
        //retrieve next answer/question set for corresponding button clicked
        if (PlayerPrefs.GetInt("Scene") == 4)
        {

                //QUESTION 1 SET
                if (thisResponse == dialogue.Responses[0])
                {
                    if (LastButtonClicked == "A")
                    {
                        //load the dialogue set for Answer A
                        UpdateDialogue(1);
                    }
                    else if (LastButtonClicked == "B")
                    {
                        //load the dialogue set for Answer B.
                        UpdateDialogue(2);
                    }
                }

                //QUESTION 2 SET
                else if (thisResponse == dialogue.Responses[1])
                {
                    if (LastButtonClicked == "A")
                    {
                        ResponseText.text = "";
                        ButtonAText.text = "";
                        ButtonBText.text = "";
                        
                        //load the dialogue set for Answer A
                        thisResponse = dialogue.Responses[0];
                        thisAnswerA = dialogue.AnswerA[0];
                        thisAnswerB = dialogue.AnswerB[0];
                    }
                    else if (LastButtonClicked == "B")
                    {
                        ResponseText.text = "";
                        ButtonAText.text = "";
                        ButtonBText.text = "";
                        
                        //load the dialogue set for Answer B.
                        thisResponse = dialogue.Responses[0];
                        thisAnswerA = dialogue.AnswerA[0];
                        thisAnswerB = dialogue.AnswerB[0];
                    }
                }

                //QUESTION 3 SET
                else if (thisResponse == dialogue.Responses[2])
                {
                    if (LastButtonClicked == "A")
                    {
                        UpdateDialogue(3);
                    }
                    else if (LastButtonClicked == "B")
                    {
                        UpdateDialogue(3);
                    }
                }

                //QUESTION 4 SET
                else if (thisResponse == dialogue.Responses[3])
                {
                    if (LastButtonClicked == "A")
                    {
                        UpdateDialogue(4);
                    }
                    else if (LastButtonClicked == "B")
                    {
                        UpdateDialogue(4);
                    }
                }

                //QUESTION 5 SET
                else if (thisResponse == dialogue.Responses[4])
                {
                    if (LastButtonClicked == "A")
                    {
                        UpdateDialogue(5);
                    }
                    else if (LastButtonClicked == "B")
                    {
                        UpdateDialogue(5);
                    }
                    
                }
                
                //QUESTION 6 SET
                else if (thisResponse == dialogue.Responses[5])
                {
                    if (LastButtonClicked == "A")
                    {
                        UpdateDialogue(6);
                    }
                    else if (LastButtonClicked == "B")
                    {
                        UpdateDialogue(7);
                    }
                }
                
                //QUESTION 7 SET
                else if (thisResponse == dialogue.Responses[6])
                {
                    if (LastButtonClicked == "A")
                    {
                        UpdateDialogue(8);
                    }
                    else if (LastButtonClicked == "B")
                    {
                        UpdateDialogue(8);
                    }
                }
                
                //QUESTION 8 SET
                else if (thisResponse == dialogue.Responses[7])
                {
                    if (LastButtonClicked == "A")
                    {
                        UpdateDialogue(8);
                    }
                    else if (LastButtonClicked == "B")
                    {
                        UpdateDialogue(8);
                    }
                }
                
                //QUESTION 9 SET
                else if (thisResponse == dialogue.Responses[8])
                {
                    if (LastButtonClicked == "A")
                    {
                        UpdateDialogue(9);
                    }
                    else if (LastButtonClicked == "B")
                    {
                        UpdateDialogue(9);
                    }
                }
                
                //QUESTION 10 SET
                else if (thisResponse == dialogue.Responses[9])
                {
                    if (LastButtonClicked == "A")
                    {
                        UpdateDialogue(10);
                    }
                    else if (LastButtonClicked == "B")
                    {
                        UpdateDialogue(10);
                    }
                }
                
                //QUESTION 11 SET
                else if (thisResponse == dialogue.Responses[10])
                {
                    if (LastButtonClicked == "A")
                    {
                        UpdateDialogue(11);
                    }
                    else if (LastButtonClicked == "B")
                    {
                        UpdateDialogue(13);
                    }
                    
                    PlayerPrefs.SetInt("Scene", 5);
                }
                
                //QUESTION 12 SET
                else if (thisResponse == dialogue.Responses[11])
                {
                    if (LastButtonClicked == "A")
                    {
                        UpdateDialogue(12);
                    }
                    else if (LastButtonClicked == "B")
                    {
                        UpdateDialogue(12);
                    }
                    
                    PlayerPrefs.SetInt("Scene", 5);
                }
        }
    }

    void UpdateDialogue(int NewSet)
    {
        //assign current question set
        thisResponse = dialogue.Responses[NewSet];
        thisAnswerA = dialogue.AnswerA[NewSet];
        thisAnswerB = dialogue.AnswerB[NewSet];
        
        //update text to display new set
        ResponseText.text = thisResponse;
        StartCoroutine("ShowAnswers");
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (other.gameObject.tag == "Player")
            {
                //only display this text if we're on the correct scene'
                if (PlayerPrefs.GetInt("Scene") == 0)
                {
                    ResponseText.text = thisResponse;
                    StartCoroutine("ShowAnswers");
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            ResponseText.text = " ";
            ButtonAText.text = " ";
            ButtonBText.text = " ";
        }
    }

    IEnumerator ShowAnswers()
    {
        //buttons turn blank for a moment
        ButtonAText.text = " ";
        ButtonBText.text = " ";
        yield return new WaitForSeconds(2);
        
        //new answers are displayed
        ButtonAText.text = thisAnswerA;
        ButtonBText.text = thisAnswerB;
    }

    public void ClickedA()
    {
        AssignDialogueSet("A");
    }
    
    public void ClickedB()
    {
        AssignDialogueSet("B");
    }
}
