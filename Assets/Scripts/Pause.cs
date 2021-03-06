﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause : MonoBehaviour {
    public GameObject player, startBtn;
    public GameController gc;
    public Text textLevel;
    public Sprite unMute, mute;

    private void Start() {
        //Populates Pause text according to level

        switch (PlayerPrefs.GetString("LevelSelected")) {
            case "Salvador":
                textLevel.text = "Nível 1\n Salvador - BA";
                break;
            case "Sao Paulo":
                textLevel.text = "Nível 2\n São Paulo - SP";
                break;
            case "Curitiba":
                textLevel.text = "Nível 3\n Curitiba - PR";
                break;
            case "Belem":
                textLevel.text = "Nível 4\n Belém - PA";
                break;
            case "Brasilia":
                textLevel.text = "Nível 5\n Brasília - DF";
                break;
            case "Rio de Janeiro":
                textLevel.text = "Nível 6\n Rio de Janeiro - RJ";
                break;
            case "Rio Branco":
                textLevel.text = "Nível 7\n Rio Branco - AC";
                break;
        }
    }
    public void OpenAndClosePause() {
        gameObject.SetActive(!gameObject.activeSelf);
        if (gameObject.activeSelf) {
            player.GetComponent<SpriteRenderer>().sortingOrder = -1;
        }
        else {
            player.GetComponent<SpriteRenderer>().sortingOrder = 1;
        }
    }
    public void Restart() {
        SceneManager.LoadScene(PlayerPrefs.GetString("LevelSelected"));
    }
    public void BackToMenu() {
        SceneManager.LoadScene("LevelSelection");
    }
    
}
