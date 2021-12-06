using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.AudioSource;

public class PlayAudio : MonoBehaviour
{
    AudioSource audioSource;
    int n;

    // Start is called before the first frame update
    void Start()
    {
        n = 0;
        audioSource = GetComponent<AudioSource>();
        //audioSource.mute = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlaySound(){
        Debug.Log(n);
        if(n==0) n=1;
        else if(n==1) audioSource.Play();
    }
}
