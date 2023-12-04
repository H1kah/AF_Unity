using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifyHealth : MonoBehaviour
{
    public int damage = 1;
    public GameObject fx;

    UIManager uimanager;

    private void Start
    {
        uimanager = FindObjectOfType<UIManager>();
    }
    private coid OnTriggerEnter2D(Collider2D collision)
    {
        if (other.CompareTag("Player"))
        {
            uimanager.SetLives(damage);
            Instantiate(fx, transform.position, Quaternion.identify);
            
            Destroy(GameObject);
        }
    }
}
