using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelect : MonoBehaviour {

    public GameObject playerPrefab;

    public void ChangeToP1()
    {
        PlayerPrefs.SetInt("Sprite", 1);
        SceneManager.LoadScene("LevelSelection");
    }

    public void ChangeToP2()
    {
        PlayerPrefs.SetInt("Sprite", 2);
        SceneManager.LoadScene("LevelSelection");
    }

    public void ChangeToP3()
    {
        PlayerPrefs.SetInt("Sprite", 3);
        SceneManager.LoadScene("LevelSelection");
    }
}
