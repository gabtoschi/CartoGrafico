using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Mute : MonoBehaviour {

    public Sprite mute, unMute;
	// Use this for initialization
	void Start () {
        if (AudioPlayback.instance.GetComponent<AudioSource>().volume == 0) {
            GameObject.Find("Mute").GetComponent<Image>().sprite = unMute;
        }
        else if(AudioPlayback.instance.GetComponent<AudioSource>().volume == 1) {
            GameObject.Find("Mute").GetComponent<Image>().sprite = mute;
        }
    }
	
	
    public void MuteButton() {
        if (AudioPlayback.instance.GetComponent<AudioSource>().volume == 1) {
            AudioPlayback.instance.GetComponent<AudioSource>().volume = 0;
            EventSystem.current.currentSelectedGameObject.GetComponent<Image>().sprite = unMute;
        }

        else {
            AudioPlayback.instance.GetComponent<AudioSource>().volume = 1;
            EventSystem.current.currentSelectedGameObject.GetComponent<Image>().sprite = mute;
        }

    }

}
