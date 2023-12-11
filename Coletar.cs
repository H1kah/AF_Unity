using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletar : MonoBehaviour
{

    public Meu_UI uimanager;
    public int score = 1;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            uimanager.SetScore(score);

            Destroy(gameObject);
        }
    }
}
