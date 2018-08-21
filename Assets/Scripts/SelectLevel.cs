using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectLevel : MonoBehaviour {

    public GameObject[] baloons;
    private bool debug = true;
    private void Start() {

        foreach(GameObject b in baloons) {
           // PlayerPrefs.DeleteKey("isLevelDone" + b.name);
            if (PlayerPrefs.HasKey("isLevelDone" + b.name)) {
                if (PlayerPrefs.GetInt("isLevelDone" + b.name) == 1) {
                    //acende os bagulho
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
        foreach(GameObject b in baloons) {
            if(!b.activeSelf && EventSystem.current.currentSelectedGameObject.name.Equals(b.name + " Btn")) {
                b.SetActive(true);
            }else if(b.activeSelf && !EventSystem.current.currentSelectedGameObject.name.Equals(b.name + " Btn")) {
                b.SetActive(false);
            }else if(b.activeSelf && EventSystem.current.currentSelectedGameObject.name.Equals(b.name + " Btn")) {
                SceneManager.LoadScene(levelName);
            }
        }
        
    }
}
