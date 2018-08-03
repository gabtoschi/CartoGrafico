﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MovementPlayer : MonoBehaviour{
    public float tempoMov;
    public GameObject buttons;
    private RaycastHit2D hit;
    public GameObject[] btnAdj;


    public void AbreQuestao(){
        GameObject btnSelected = EventSystem.current.currentSelectedGameObject;
        for(int i=0; i<btnAdj.Length; i++)
        {
            if (btnSelected.name.Equals(btnAdj[i].name)) //Check if selected button is in list
            {
                StartCoroutine(MovePlayer(btnSelected.GetComponent<RectTransform>()));
            }
        }
    }

    public IEnumerator MovePlayer(RectTransform finalPos)
    {
        Button[] btn = buttons.GetComponentsInChildren<Button>();
        var currentPos = GetComponent<RectTransform>().position; 
        var t = 0f;
        foreach(Button b in btn)
        {
            b.enabled = false; //disable buttons to prevent starting another movement without finishing the last one
        }
        while (t < 1)
        {
            t += Time.deltaTime / tempoMov;

            GetComponent<RectTransform>().position = Vector3.Lerp(currentPos,finalPos.position , t); //translates object smoothly according to given time
            yield return null;
        }
        foreach (Button b in btn)
        {
            b.enabled = true; //enables buttons again
        }
        
    }

}
