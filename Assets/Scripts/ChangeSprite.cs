using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour {

    public Sprite p1, p2, p3, p4;
	// Use this for initialization
	void Start () {
        switch (PlayerPrefs.GetInt("Sprite")) {
            case 1:
                GetComponent<SpriteRenderer>().sprite = p1;
                break;
            case 2:
                GetComponent<SpriteRenderer>().sprite = p2;
                break;
            case 3:
                GetComponent<SpriteRenderer>().sprite = p3;
                break;
            case 4:
                GetComponent<SpriteRenderer>().sprite = p4;
                break;
        }
	}
	
	
}
