using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPlayerController : MonoBehaviour
{
    public Rigidbody2D LeftRB;
    public Animator LeftAnimController;
    public SpriteRenderer LeftSR;
    
    public float Speed;

    public bool Interacting = false;


    // Start is called before the first frame update
    void Start()
    {
        if (LeftRB == null)
        {
            LeftRB = GetComponent<Rigidbody2D>();
        } 
    }

    // Update is called once per frame
    void Update()
    {
        Interacting = false;
        
        Vector2 LVel = LeftRB.velocity;
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            LVel.x = Speed;
            LeftAnimController.SetBool("LIsWalking", true);
            LeftSR.flipX = false;
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            LVel.x = -Speed;
            LeftAnimController.SetBool("LIsWalking", true);
            LeftSR.flipX = true;
        }

        else
        {
            LVel.x = 0;
            LeftAnimController.SetBool("LIsWalking", false);
        }
        
        LeftRB.velocity = LVel;
    }
}

