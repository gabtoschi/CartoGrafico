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
    public string nextLevel;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (isFinal) {
                GetComponent<Image>().sprite = Resources.Load<Sprite>("questionmark");
                //Unlocks next level after completion and saves it in Player Prefs
                PlayerPrefs.SetInt("isLevelDone"+nextLevel, 1);
                PlayerPrefs.Save();
                //open victory pannel
                SceneManager.LoadScene("TelaVitoria");
            }
            else {
                for (int i = 0; i < btnAdj.Length; i++) {
                    //Changes sprites of adjacent buttons according to type
                    if(!btnAdj[i].GetComponent<PlayerEnter>().isFinal)
                        btnAdj[i].GetComponent<Image>().sprite = Resources.Load<Sprite>("questionmarksel");          
                    else
                        btnAdj[i].GetComponent<Image>().sprite = Resources.Load<Sprite>("pinsel");
                }
                player.GetComponent<MovementPlayer>().btnAdj = btnAdj;
                Debug.Log(btnAdj.Length);

            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.CompareTag("Player")) {
            for (int i = 0; i < btnAdj.Length; i++) {
                if (!btnAdj[i].GetComponent<PlayerEnter>().isFinal)
                    btnAdj[i].GetComponent<Image>().sprite = Resources.Load<Sprite>("questionmark");
                else
                    btnAdj[i].GetComponent<Image>().sprite = Resources.Load<Sprite>("pin");
            }
        }
    }
}

