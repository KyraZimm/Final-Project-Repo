using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMarkerScript : MonoBehaviour
{
    public GameObject Character;
    private SpriteRenderer sprite;
   
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

 
    void Update()
    {
        //stay next to Jenny
        transform.position = new Vector2(Character.transform.position.x - 1f, Character.transform.position.y + 1f);
        
        //turn it on/off
        if (PlayerPrefs.GetInt("Scene") == 0
            || PlayerPrefs.GetInt("Scene") == 2
            || PlayerPrefs.GetInt("Scene") == 4)
        {
            sprite.color = new Color(1, 1, 1, 1);
        }
        else
        {
            sprite.color = new Color(1, 1, 1, 0);
        }
    }
}
