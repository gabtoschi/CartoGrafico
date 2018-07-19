using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class button : MonoBehaviour{
    public GameObject player;

    public void AbreQuestao(){
        player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<RectTransform>().position = EventSystem.current.currentSelectedGameObject.GetComponent<RectTransform>().position;
    }
}
