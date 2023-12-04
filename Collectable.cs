using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    UIManager uimanager;
    private void Start()
    {
    uimanager = FindObjectType<UIManager>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
        uimanager.SetScore(1);
        Destroy(gameObject);
        }
    }
}