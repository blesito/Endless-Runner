using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class SoundPopping: MonoBehaviour{

    public AudioClip triggerSound;
    AudioSource audioSource;
    public bool isPlaying;


    void Start(){
        audioSource = GetComponent<AudioSource>();

    }
    void Update(){

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy" && isPlaying == false)
        {
            audioSource.PlayOneShot(triggerSound);
            isPlaying = true;
        }
    }
    private void OnTriggerExit(Collider other){
        if(other.tag == "Enemy" && isPlaying == true){
            isPlaying = false;
        }
    }
}
