using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayback : MonoBehaviour {
    [HideInInspector] public static AudioPlayback instance;

    private AudioSource audioSource;

    private void Awake() {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);

    }

    private void OnLevelWasLoaded(int level) {
        audioSource = GetComponent<AudioSource>();
        if(level==6 || level==7 || level==8 || level==9 || level==10 || level==11 || level == 12) {
            audioSource.clip = Resources.Load<AudioClip>("Sound/game");
            audioSource.Play(0);
        }
        else {
            if (!audioSource.clip.Equals(Resources.Load<AudioClip>("Sound/menus")) || audioSource.clip==null) {
                audioSource.clip =  Resources.Load<AudioClip>("Sound/menus");
                audioSource.Play(0);
            }
        }
    }
}
