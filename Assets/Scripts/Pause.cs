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
