using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIScript : MonoBehaviour
{
    public TMP_Text _text;
    private Image background;
    
    void Start()
    {
        background = GetComponent<Image>();
    }

    
    void Update()
    {
        if (_text.text == "" || _text.text == " ")
        {
            background.color = new Color(0, 0, 0, 0);
        }
        else
        {
            background.color = new Color(0, 0, 0, 0.4f);
        }
    }
}
