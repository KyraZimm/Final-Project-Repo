using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBehaviorScript : MonoBehaviour
{
    public GameObject player;
    private SpriteRenderer sprite;
    
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        //sprite direction
        if (player.transform.position.x > gameObject.transform.position.x)
        {
            sprite.flipX = false;
        }
        else
        {
            sprite.flipX = true;
        }
    }
}
