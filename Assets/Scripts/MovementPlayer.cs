
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MovementPlayer : MonoBehaviour{
    public float tempoMov;
    public GameObject[] btnAdj;
    public Text panelText, stepText;
    public Text[] answerTexts;
    public GameObject questionPanel, grid, closeButton, buttons;
    private Question currentQuestion = null;
    private int btnIndex = -1;
    private GameObject btnSelected;
    private int stepCount=0;
    public Image img;
    private Sprite spriteFact;

    public void OpenQuestion(){
        Debug.Log("Movement PLayer: " + btnAdj.Length);
        bool check = false;
        btnSelected = EventSystem.current.currentSelectedGameObject; //Get the selected movement button
        for (int i = 0; i < btnAdj.Length; i++) {
            if (btnSelected.name.Equals(btnAdj[i].name)) //Check if selected button is in list
            {
                check = true;
            }
        }
        if (check){
            currentQuestion = QuestionManager.instance.getNextQuestion(); //Get question on question pack and populates texts and buttons
            UpdateStartPanel();
            questionPanel.SetActive(true);
            buttons.SetActive(false);
            grid.SetActive(false);          
            GetComponent<SpriteRenderer>().enabled = false;
            for (int i = 0; i < 3; i++) {
                answerTexts[i].GetComponentInParent<Image>().enabled = true;
                answerTexts[i].enabled = true;
            }
            closeButton.SetActive(false);
        }


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
        string textToPanel = isCorrect ? "Muito bem!\nVocê acertou!\n\n" : "Poxa, não foi dessa vez.\nTente novamente.\n\n"; // Populates panel text according to answer
        textToPanel += currentQuestion.fact;
        panelText.text = textToPanel;
        for(int i=0; i < 3; i++)
        {
            answerTexts[i].GetComponentInParent<Image>().enabled =false; //Deactivates answer buttons after answering question
            answerTexts[i].enabled = false;
        }
        closeButton.SetActive(true);
        if (!currentQuestion.url.Equals("")) { //Activates and populates image if url is not null
            img.gameObject.SetActive(true);
            spriteFact = Resources.Load<Sprite>("Imgs Facts/" + currentQuestion.url);
            if(spriteFact!=null)
                img.sprite = spriteFact;
        }
    }

    public void ClosePanel()
    {
        questionPanel.SetActive(false); //   V
        buttons.SetActive(true); //    Deactivates question panel and activates buttons and grid 
        grid.SetActive(true); //      ^
        GetComponent<SpriteRenderer>().enabled = true;
        if (currentQuestion.correct == btnIndex)
        {
           StartCoroutine(MovePlayer(btnSelected.GetComponent<RectTransform>())); 
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
