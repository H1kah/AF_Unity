using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacao : MonoBehaviour
{
    Rigidbody2D rb;
    public float Torque = 5;
    float hor;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        rb.AddTorque(hor * Torque * -1);
    }
}