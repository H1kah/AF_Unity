using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 direction;
    public float force = 1;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //qualquer coisa, só muda pra horizontal
        float ver = Input.GetAxis("Vertical");
        direction = new Vector2(0, ver);

        rb.AddForce(direction * force);
    }
}
