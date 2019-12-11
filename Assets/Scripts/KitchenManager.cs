using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenManager : MonoBehaviour
{

    public MomScript momConvo;
    public MessHallDialogue jennyConvo;


    void Update()
    {
        if (momConvo.interactionOver && jennyConvo.interactionOver)
        {
            PlayerPrefs.SetInt("Scene", 4);
        }
    }
}
