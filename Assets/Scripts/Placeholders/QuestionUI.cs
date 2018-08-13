using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionUI : MonoBehaviour {

	public GameObject questionPanel;
	public GameObject startButton;
	public GameObject closeButton;
	public Text panelText;
	public GameObject answerButtons;
	public Text[] answerTexts;

	public Question currentQuestion = null;

	public void startNewQuestion(){
		currentQuestion = QuestionManager.instance.getNextQuestion();

		Debug.Log("question loaded is " + currentQuestion.question);
		updateStartPanel();
		questionPanel.SetActive(true);
		answerButtons.SetActive(true);
		startButton.SetActive(false);
	}

	private void updateStartPanel(){
		panelText.text = currentQuestion.question;
		for (int i = 0; i < 4; i++){
			answerTexts[i].text = currentQuestion.answers[i];
		}
	}

	public void answerQuestion(int answer){
		updateEndPanel(answer == currentQuestion.correct ? true : false);
	}

	private void updateEndPanel(bool isCorrect){
		string textToPanel = isCorrect ? "VOCÊ ACERTOU\n\n" : "VOCÊ ERROU\n\n";
		textToPanel += currentQuestion.fact;
		panelText.text = textToPanel;

		answerButtons.SetActive(false);
		closeButton.SetActive(true);
	}

	public void closePanel(){
		currentQuestion = null;
		
		questionPanel.SetActive(false);
		startButton.SetActive(true);
		closeButton.SetActive(false);
	}
}
