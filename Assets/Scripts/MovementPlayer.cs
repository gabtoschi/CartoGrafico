using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MovementPlayer : MonoBehaviour{
    public float tempoMov;
    public GameObject buttons;
    //private RaycastHit2D hitUp, hitDown, hitLeft, hitRight;
    private RaycastHit2D hit;

  /*  private void Update()
    {
        //Raycast in 4 directions
        hitUp = Physics2D.Raycast(GetComponent<RectTransform>().position, Vector2.up);
        hitDown = Physics2D.Raycast(GetComponent<RectTransform>().position, Vector2.down);
        hitLeft = Physics2D.Raycast(GetComponent<RectTransform>().position, Vector2.left);
        hitRight = Physics2D.Raycast(GetComponent<RectTransform>().position, Vector2.right);
    }*/
    public void AbreQuestao(){

        //Check if the name of the button got from the raycast has the same name as the selected button

        Vector3 or = transform.position;
        Vector3 dir = EventSystem.current.currentSelectedGameObject.transform.position;
        hit = Physics2D.Raycast(or, dir);
        if(hit.collider !=null && hit.collider.name.Equals(EventSystem.current.currentSelectedGameObject.name))
        {
            StartCoroutine(MovePlayer(EventSystem.current.currentSelectedGameObject.GetComponent<RectTransform>()));
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
