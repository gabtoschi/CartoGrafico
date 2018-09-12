using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    public int minSteps;
    public bool hasKey;
	void Start () {

        QuestionManager.instance.loadQuestionPackFile();
	}
	

}
