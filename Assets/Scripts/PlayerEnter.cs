using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnter : MonoBehaviour
{
    public GameObject[] btnAdj;
    public MovementPlayer mp;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            mp.btnAdj = btnAdj;
        }
    }
    
}
