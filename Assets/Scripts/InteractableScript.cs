using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InteractableScript : MonoBehaviour
{
    private bool interact;

    public TextAsset JSONInteractions;
    private Interactions interactionList;

    public TMP_Text CareyThoughts;

    [Serializable]
    public struct Interactions
    {
        public string[] Lines;
    }

    void Start()
    {
        //set initial value
        interact = false;
        
        //unpack JSON
        interactionList = JsonUtility.FromJson<Interactions>(JSONInteractions.text);

        CareyThoughts.text = " ";
    }

   
    void Update()
    {
        //allow interaction
        if (interact)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                StartCoroutine("ShowThoughts");
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

    IEnumerator ShowThoughts()
    {
        CareyThoughts.text = interactionList.Lines[0];
        yield return new WaitForSeconds(3);
        Debug.Log("text should be hidden");
        CareyThoughts.text = " ";
    }
}
