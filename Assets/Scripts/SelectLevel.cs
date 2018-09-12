using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectLevel : MonoBehaviour {

    public GameObject[] balloons;
    private void Start() {
        foreach(GameObject b in balloons) {
            //Check if isLevelDone is in registry
            if (PlayerPrefs.HasKey("isLevelDone" + b.name)) {
                //Activate button script according to completed levels in Player Prefs
                if (PlayerPrefs.GetInt("isLevelDone" + b.name) == 1) {
                    b.GetComponentInParent<Button>().enabled = true;
                    b.GetComponentInParent<Image>().color = Color.white;
                }
            }
            else {
                PlayerPrefs.SetInt("isLevelDone" + b.name, 0);
            }
        }
    }

    
    
    public void EnterLevel(string levelName) {
        //Opens balloon with levvel details and if selected again, enters in level. If other button is selected, closes the balloon and opens the new one
        foreach(GameObject b in balloons) {
            if(!b.activeSelf && EventSystem.current.currentSelectedGameObject.name.Equals(b.name + " Btn")) {
                b.SetActive(true);
            }else if(b.activeSelf && !EventSystem.current.currentSelectedGameObject.name.Equals(b.name + " Btn")) {
                b.SetActive(false);
            }else if(b.activeSelf && EventSystem.current.currentSelectedGameObject.name.Equals(b.name + " Btn")) {
                if (QuestionManager.instance != null) {
                    Destroy(QuestionManager.instance);
                    Destroy(GameObject.Find("GameController"));
                    QuestionManager.instance = new QuestionManager();
                    QuestionManager.instance.packFilename = levelName;
                    QuestionManager.instance.loadQuestionPackFile();
                }
                PlayerPrefs.SetString("LevelSelected", levelName);
                SceneManager.LoadScene("LevelPresentation");
            }
        }
        
    }
}
