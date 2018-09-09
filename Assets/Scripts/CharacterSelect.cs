using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelect : MonoBehaviour {

    public GameObject playerPrefab;
    public Sprite p1, p2, p3;

    public void ChangeToP1()
    {
        playerPrefab.GetComponent<SpriteRenderer>().sprite = p1;
        SceneManager.LoadScene("LevelSelection");
    }

    public void ChangeToP2()
    {
        playerPrefab.GetComponent<SpriteRenderer>().sprite = p2;
        SceneManager.LoadScene("LevelSelection");
    }

    public void ChangeToP3()
    {
        playerPrefab.GetComponent<SpriteRenderer>().sprite = p3;
        SceneManager.LoadScene("LevelSelection");
    }
}
