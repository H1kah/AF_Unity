using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_2 : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision Player");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Trigger Player");
    }
}
