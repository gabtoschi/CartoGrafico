using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class AspectScaler : MonoBehaviour {
	void Start () {
        //Change base resolution according to different aspect ratios
        float aspect = (float)Screen.width / (float)Screen.height;
        Debug.Log(Screen.height + " x " +Screen.width);
        Debug.Log(aspect);
        if (aspect == 9f / 18.5f) {
            GetComponent<CanvasScaler>().referenceResolution = new Vector2(1332.5f, 668f);
        }

    }
	
}
