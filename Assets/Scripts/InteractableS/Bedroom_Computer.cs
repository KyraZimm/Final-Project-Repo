using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class Bedroom_Computer : MonoBehaviour
{
    //UI
    public TMP_Text RealityText;
    public TMP_Text FantasyText;
    
    //sprite
    private SpriteRenderer sprite;

    //update set
    private int currentSet;
    private bool CheckForUpdate;
    
    //JSON
    public TextAsset JsonFile;
    private UIText CanvasText;
    
    [Serializable]
    public struct UIText
    {
        public string[] Reality;
        public string[] Fantasy;
    }

    private void Start()
    {
        currentSet = -1;
        CanvasText = JsonUtility.FromJson<UIText>(JsonFile.text);
        CheckForUpdate = false;
        sprite = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (CheckForUpdate)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (PlayerPrefs.GetInt("Scene") == 1)
                {
                    UpdateText();
                }
            }
        }

        if (currentSet >= 10)
        {
            PlayerPrefs.SetInt("Scene", 2);
            sprite.color = new Color(1, 1, 1, 0);
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(PlayerPrefs.GetInt("Scene"));
        
        if (other.gameObject.tag == "Player")
        {
            CheckForUpdate = true;
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            CheckForUpdate = false;
            RealityText.text = "";
            FantasyText.text = "";
        }
    }

    void UpdateText()
    {
        var nextSet = currentSet + 1;

        RealityText.text = CanvasText.Reality[nextSet];
        FantasyText.text = CanvasText.Fantasy[nextSet];

        currentSet = nextSet;
    }
}
