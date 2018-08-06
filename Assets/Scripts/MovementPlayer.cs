
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MovementPlayer : MonoBehaviour{
    public float tempoMov;
    public GameObject buttons;
    private RaycastHit2D hit;
    public GameObject[] btnAdj;
    private Question currentQuestion = null;
    public Text panelText, stepText;
    public Text[] answerTexts;
    public GameObject questionPanel, grid, closeButton;
    private int btnIndex = -1;
    private GameObject btnSelected;
    private int stepCount=0;

    public void OpenQuestion(){
        btnSelected = EventSystem.current.currentSelectedGameObject; //Get the selected movement button
        currentQuestion  = QuestionManager.instance.getNextQuestion(); //Get question on question pack
        UpdateStartPanel();
        questionPanel.SetActive(true);
        buttons.SetActive(false);
        grid.SetActive(false);

        GetComponent<SpriteRenderer>().enabled = false;
        for (int i = 0; i < 3; i++)
        {
            answerTexts[i].GetComponentInParent<Image>().enabled = true;
            answerTexts[i].enabled = true;
        }
        closeButton.SetActive(false); 
        
        
    }
    private void UpdateStartPanel()
    {
        panelText.text = currentQuestion.question;
        for (int i = 0; i < 3; i++)
        {
            answerTexts[i].text = currentQuestion.answers[i];
        }
    }

    public void AnswerQuestion(int answer)
    {
        btnIndex = answer; //Gets answer button index for further checking
        updateEndPanel(answer == currentQuestion.correct ? true : false);
    }

    private void updateEndPanel(bool isCorrect)
    {
        string textToPanel = isCorrect ? "VOCÊ ACERTOU\n\n" : "VOCÊ ERROU\n\n"; // Populates panel text according to answer
        textToPanel += currentQuestion.fact;
        panelText.text = textToPanel;
        for(int i=0; i < 3; i++)
        {
            answerTexts[i].GetComponentInParent<Image>().enabled =false; //Deactivates answer buttons after answering question
            answerTexts[i].enabled = false;
        }
        closeButton.SetActive(true);
    }

    public void ClosePanel()
    {
        questionPanel.SetActive(false); //   V
        buttons.SetActive(true); //    Deactivates question panel and activates buttons and grid 
        grid.SetActive(true); //      ^
        GetComponent<SpriteRenderer>().enabled = true;
        if (currentQuestion.correct == btnIndex)
        {
            for (int i = 0; i < btnAdj.Length; i++)
            {
                if (btnSelected.name.Equals(btnAdj[i].name)) //Check if selected button is in list
                {
                    StartCoroutine(MovePlayer(btnSelected.GetComponent<RectTransform>()));
                }
            }
            stepCount++; //Add 1 step for each question answered right
            UpdateSteps();
        }
    }
    private void UpdateSteps()
    {
        stepText.text = "Passos:"+ '\n' + stepCount;
    }
    public IEnumerator MovePlayer(RectTransform finalPos)
    {
        Button[] btn = buttons.GetComponentsInChildren<Button>();
        var currentPos = GetComponent<RectTransform>().position; 
        var t = 0f;
        foreach(Button b in btn)
        {
            b.enabled = false; //disable buttons to prevent starting another movement without finishing the last one
        }
        while (t < 1)
        {
            t += Time.deltaTime / tempoMov;

            GetComponent<RectTransform>().position = Vector3.Lerp(currentPos,finalPos.position , t); //translates object smoothly according to given time
            yield return null;
        }
        foreach (Button b in btn)
        {
            b.enabled = true; //enables buttons again
        }
        
    }

}
