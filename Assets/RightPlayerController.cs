using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPlayerController : MonoBehaviour
{
    public Rigidbody2D RightRB;
    public Animator RightAnimController;
    public SpriteRenderer RightSR;
    
    public float Speed;

    public bool Interacting = false;


    // Start is called before the first frame update
    void Start()
    {
        if (RightRB == null)
        {
            RightRB = GetComponent<Rigidbody2D>();
        } 
    }

    // Update is called once per frame
    void Update()
    {
        Interacting = false;

        Vector2 RVel = RightRB.velocity;
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            RVel.x = Speed;
            RightAnimController.SetBool("RIsWalking", true);
            RightSR.flipX = false;
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            RVel.x = -Speed;
            RightAnimController.SetBool("RIsWalking", true);
            RightSR.flipX = true;
        }

        else
        {
            RVel.x = 0;
            RightAnimController.SetBool("RIsWalking", false);
        }
        
        RightRB.velocity = RVel;
    }
}

