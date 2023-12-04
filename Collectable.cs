using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision");
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        print("Trigger");
    }
}