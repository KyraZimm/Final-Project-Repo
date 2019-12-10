using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HallwayManager : MonoBehaviour
{

    public GameObject playerR;
    public GameObject playerF;
    
    //scene 0
    public DadScript dadConvo;
    public HallwayDialogue_Jenny jennyConvo;
    
    //scene 2
    public DadScript2 dadConvo2;
    public HallwayDialogue_2 jennyConvo2;
   
    void Start()
    {

        //mark door that Carey walks out of
        if (PlayerPrefs.GetInt("LastDoorUsed") == 1)
        {
            playerR.transform.position = new Vector2(-40, 11.9f);
            playerF.transform.position = new Vector2(-40, -13.4f);
        }
        else if (PlayerPrefs.GetInt("LastDoorUsed") == 2)
        {
            playerR.transform.position = new Vector2(-10, 11.9f);
            playerF.transform.position = new Vector2(-10, -13.4f);
        }
        else if (PlayerPrefs.GetInt("LastDoorUsed") == 3)
        {
            playerR.transform.position = new Vector2(40, 11.9f);
            playerF.transform.position = new Vector2(40, -13.4f);
        }
    }

    void Update()
    {
        //control scene settings
        if (PlayerPrefs.GetInt("Scene") == 0)
        {
            Debug.Log("scene is 0");
            Debug.Log(dadConvo.interactionOver);
            Debug.Log(jennyConvo.interactionOver);
            if (dadConvo.interactionOver && jennyConvo.interactionOver)
            {
                Debug.Log("interactions are over");
                PlayerPrefs.SetInt("Scene", 1);
            }
        }
        /*
        else if (PlayerPrefs.GetInt("Scene") == 2)
        {
            if (dadConvo2.interactionOver && jennyConvo2.interactionOver)
            {
                PlayerPrefs.SetInt("Scene", 3);
            }
        }
        */

    }

}
