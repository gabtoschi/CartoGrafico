using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLevel : MonoBehaviour {

	public void EnterLevel(string levelName) {
        SceneManager.LoadScene(levelName);
    }
}
