using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleChildren : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ToggleAllChildren (bool newValue)
    {

        if(newValue)
        {
            foreach (Image img in this.transform.GetComponentsInChildren<Image>())
            {
                img.enabled = true;
            }
        }
        else
        {
            foreach (Image img in this.transform.GetComponentsInChildren<Image>())
            {
                img.enabled = false;
            }
        }


    }
}
