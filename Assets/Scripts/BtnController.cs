using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnController : MonoBehaviour {

    private string privacyPolicyLink = "https://github.com/gabtoschi/CartoGrafico/blob/master/privacy_policy.md";

	public void StartBtn()
    {
        //Debug.Log("OI");
        if (PlayerPrefs.HasKey("MinSteps") && PlayerPrefs.HasKey("StepsDone")){
            PlayerPrefs.DeleteKey("MinSteps");
            PlayerPrefs.DeleteKey("StepsDone");
        }
        SceneManager.LoadScene("CharacterSelect");
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

    public void OpenPrivacyPolicy() {
        Application.OpenURL(privacyPolicyLink);
    }
}
