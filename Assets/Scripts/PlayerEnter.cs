using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerEnter : MonoBehaviour
{
    public GameObject[] btnAdj;
    public MovementPlayer mp;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            for(int i=0; i<btnAdj.Length; i++) {
                btnAdj[i].GetComponent<Image>().color = Color.yellow;
            }
            mp.btnAdj = btnAdj;
            Debug.Log(btnAdj.Length);
        }
    }
    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.CompareTag("Player")) {
            for (int i = 0; i < btnAdj.Length; i++) {
                btnAdj[i].GetComponent<Image>().color = Color.black;
            }
        }
    }

}
