using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause : MonoBehaviour {
    public GameObject player, startBtn;
    public GameController gc;
    public Text textLevel;

    private void Start() {
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
    }
    public void Restart() {
        player.transform.position = startBtn.transform.position;
        player.GetComponent<MovementPlayer>().SetStep(0);
        player.GetComponent<MovementPlayer>().UpdateSteps();
        OpenAndClosePause();
    }
    public void BackToMenu() {
        SceneManager.LoadScene("LevelSelection");
    }
}
