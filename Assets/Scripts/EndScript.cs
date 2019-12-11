using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour
{

    public string StartScene;new
        
    public void NewGame()
    {
        SceneManager.LoadScene(StartScene);
    }




}
