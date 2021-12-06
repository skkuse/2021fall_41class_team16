using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio2 : MonoBehaviour
{
    int n;
    public AudioSource openSound;
    public AudioSource closeSound;
    // Start is called before the first frame update
    void Start()
    {
        n = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void open(){
        openSound.Play();
    }

    void close(){
        if(n==0) n=1;
        else if(n==1) closeSound.Play();
    }
}
