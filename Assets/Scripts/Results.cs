using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Results : MonoBehaviour {

    public Text resultText;
    public GameObject[] stars;
    public GameObject starField;
    private float score;

	void Start () {
        resultText.text = "O caminho mínimo era de " + PlayerPrefs.GetInt("MinSteps") + " passos.\n Você deu " + PlayerPrefs.GetInt("StepsDone") + " passos.";
        //Calculates score with formula (1/Steps Done/Min Steps)
        score = (float)((float)PlayerPrefs.GetInt("MinSteps") / (float)PlayerPrefs.GetInt("StepsDone"));
        ShowStars();
        Debug.Log(score);
    }
	private void ShowStars() {
        //Places different quantity of stars according to the score and repositions them
        if(score>=0.0f && score < 0.2f) {
            stars[0].SetActive(true);
            starField.transform.localPosition = new Vector2(0, 13);
        }else if(score >=0.2f && score < 0.4f) {
            for (int i = 0; i < 2; i++)
                stars[i].SetActive(true);
            starField.transform.localPosition = new Vector2(-33, 13);

        }
        else if(score >=0.4f && score < 0.6f) {
            for (int i = 0; i < 3; i++)
                stars[i].SetActive(true);

        }
        else if(score >=0.6f && score < 0.8f) {
            for (int i = 0; i < 4; i++)
                stars[i].SetActive(true);
            starField.GetComponent<Transform>().localPosition = new Vector3(-25,13,0);
        }
        else if(score >=0.8f && score <= 1f) {
            for (int i = 0; i < 5; i++)
                stars[i].SetActive(true);

        }
    }
	
}
