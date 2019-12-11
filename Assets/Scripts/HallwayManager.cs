using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HallwayManager : MonoBehaviour
{
    
    //audio
    public AudioSource audioLeft;
    public AudioSource audioRight;
    public AudioClip Door_R;
    public AudioClip Door_F;

    //player references
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
        //play door sound
        audioLeft.PlayOneShot(Door_R);
        audioRight.PlayOneShot(Door_F);

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
        
        else if (PlayerPrefs.GetInt("Scene") == 2)
        {
            if (dadConvo2.interactionOver && jennyConvo2.interactionOver)
            {
                PlayerPrefs.SetInt("Scene", 3);
            }
        }

    }

}
