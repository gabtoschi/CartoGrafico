﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelect : MonoBehaviour {

    public void ChangeSprite(int spriteNumber)
    {
        PlayerPrefs.SetInt("Sprite", spriteNumber);
        SceneManager.LoadScene("LevelSelection");
    }

   
}
