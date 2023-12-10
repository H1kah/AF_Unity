using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //o que um player tem? Vida
    public int vida;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            vida -= 1;
            
            if(vida == 0)
            {
                Destroy(gameObject);
                Debug.Log("You Lose");
            }
        }
    }
}