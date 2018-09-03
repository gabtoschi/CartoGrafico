using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyAndLock : MonoBehaviour {

	public GameObject gLock, prevBtn, finalBtn, gc;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gc.GetComponent<GameController>().hasKey = true;
            gameObject.GetComponent<SpriteRenderer>().enabled=false;
            gameObject.GetComponent<Collider2D>().enabled = false;
            prevBtn.GetComponent<PlayerEnter>().btnAdj.Add(finalBtn);
        }
    }

    public void OpenGate()
    {
        gLock.SetActive(false);
    }
    private void Start()
    {
        gc = GameObject.FindWithTag("GameController");
    }
}
