using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnController : MonoBehaviour {

	public void StartBtn()
    {
        //Debug.Log("OI");
        if (PlayerPrefs.HasKey("MinSteps") && PlayerPrefs.HasKey("StepsDone")){
            PlayerPrefs.DeleteKey("MinSteps");
            PlayerPrefs.DeleteKey("StepsDone");
        }
        SceneManager.LoadScene("LevelSelection");
    }
    public void TutorialBtn()
    {
        SceneManager.LoadScene("Tutorial");

    }
    public void CreditBtn()
    {
        SceneManager.LoadScene("Creditos");
    }
    
    public void TeachersBtn()
    {
        SceneManager.LoadScene("Teachers");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("menu");
    }

    public void FinishLevel()
    {
        if (PlayerPrefs.GetInt("isLevelDoneFinal") == 1 && PlayerPrefs.GetString("LevelSelected").Equals("Rio Branco"))
        {
            SceneManager.LoadScene("TelaParabens");
        }
        else
        {
            SceneManager.LoadScene("LevelSelection");
        }
    }
}
