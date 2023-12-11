using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Meu_UI uimanager;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            uimanager.SetVida(1);
            
            if(uimanager.vida <= 0)
            {
                uimanager.GameOver();
                Destroy(gameObject);
            }
        }
    }
}