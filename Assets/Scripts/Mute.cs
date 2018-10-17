using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Mute : MonoBehaviour {

    public Sprite mute, unMute;
        //Changes Volume and sprite according to volume at start of the scene
    void Start () {
        if (AudioPlayback.instance.GetComponent<AudioSource>().volume == 0) {
            GameObject.Find("Mute").GetComponent<Image>().sprite = mute;
        }
        else if(AudioPlayback.instance.GetComponent<AudioSource>().volume == 1) {
            GameObject.Find("Mute").GetComponent<Image>().sprite = unMute;
        }
    }
	
	
    public void MuteButton() {
        //Changes volume and button's sprite
        if (AudioPlayback.instance.GetComponent<AudioSource>().volume == 1) {
            AudioPlayback.instance.GetComponent<AudioSource>().volume = 0;
            EventSystem.current.currentSelectedGameObject.GetComponent<Image>().sprite = mute;
        }

        else {
            AudioPlayback.instance.GetComponent<AudioSource>().volume = 1;
            EventSystem.current.currentSelectedGameObject.GetComponent<Image>().sprite = unMute;
        }

    }

}
