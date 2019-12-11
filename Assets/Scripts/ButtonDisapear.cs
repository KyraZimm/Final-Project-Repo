using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDisapear : MonoBehaviour
{
    public GameObject AnswerA;

    public GameObject AnswerB;
    // Start is called before the first frame update
    void Start()
    {
        AnswerA.SetActive(false);
        AnswerB.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
   
}
