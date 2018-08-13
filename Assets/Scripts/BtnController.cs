﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnController : MonoBehaviour {

	public void StartBtn()
    {
        //Debug.Log("OI");
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
}