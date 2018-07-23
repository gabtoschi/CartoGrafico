using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MovementPlayer : MonoBehaviour{
    public GameObject player;
    public float tempoMov;
    public GameObject buttons;
     
    public void AbreQuestao(){
            StartCoroutine(MovePlayer(EventSystem.current.currentSelectedGameObject.GetComponent<RectTransform>()));
    }

    public IEnumerator MovePlayer(RectTransform finalPos)
    {
        Button[] btn = buttons.GetComponentsInChildren<Button>();
        player = GameObject.FindGameObjectWithTag("Player");
        var currentPos = player.GetComponent<RectTransform>().position;
        var t = 0f;
        foreach(Button b in btn)
        {
            b.enabled = false;
        }
        while (t < 1)
        {
            t += Time.deltaTime / tempoMov;

            player.GetComponent<RectTransform>().position = Vector3.Lerp(currentPos,finalPos.position , t);
            yield return null;
        }
        foreach (Button b in btn)
        {
            b.enabled = true;
        }

    }

}
