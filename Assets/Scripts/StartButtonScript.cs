using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButtonScript : MonoBehaviour
{
    public Button StartButton;
    
    void Start()
    {
        StartButton = GetComponent<Button>();
        StartButton.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        PlayerPrefs.SetInt("Scene", 0);
        SceneManager.LoadScene("Scenes/HallwayScene");
    }
}
