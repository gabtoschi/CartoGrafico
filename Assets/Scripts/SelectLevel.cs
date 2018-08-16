using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SelectLevel : MonoBehaviour {

    public GameObject[] baloons;
    private bool selected = false;

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
