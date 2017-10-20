using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour {

    public AudioSource myAudioSource;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ToggleAudio(bool newValue)
    {
        try
        {
            if (newValue)
            {
                myAudioSource.mute = false;
            }
            else
            {
                myAudioSource.mute = true;
            }
        }
        catch (NullReferenceException ex)
        {

        }
    }
}
