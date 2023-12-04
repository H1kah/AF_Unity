using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    Rigidbody2D rb;
    public float torque = 1;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        rb.AddTorque(hor * torque * -1);
    }
}
