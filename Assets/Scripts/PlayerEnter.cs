using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerEnter : MonoBehaviour
{
    public GameObject[] btnAdj;
    public GameObject player;
    public bool isFinal;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (isFinal) {
                //open victory pannel
                SceneManager.LoadScene("TelaVitoria");
            }
            else {
                for (int i = 0; i < btnAdj.Length; i++) {
                    btnAdj[i].GetComponent<Image>().color = Color.yellow;
                }
                player.GetComponent<MovementPlayer>().btnAdj = btnAdj;
                Debug.Log(btnAdj.Length);

            }
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
