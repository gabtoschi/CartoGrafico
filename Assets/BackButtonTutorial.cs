using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonTutorial : MonoBehaviour {

	public void ChangeScene(){
        SceneManager.LoadScene("menu");
    }
}
