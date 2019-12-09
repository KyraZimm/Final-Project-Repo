using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallwayDoorManager : MonoBehaviour
{

    public GameObject playerR;
    public GameObject playerF;
   
    void Start()
    {
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

}
