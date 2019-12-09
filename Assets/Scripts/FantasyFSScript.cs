using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FantasyFSScript : MonoBehaviour
{
    public AudioSource AS;
    public AudioClip Footstep01;
    public AudioClip Footstep02;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayF01()
    {
        AS.pitch = Random.Range(0.8f, 1.2f);
        AS.PlayOneShot(Footstep01);
    }

    public void PlayF02()
    {
        AS.pitch = Random.Range(0.8f, 1.2f);
        AS.PlayOneShot(Footstep02);
    }
}