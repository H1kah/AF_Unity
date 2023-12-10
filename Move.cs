using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    private Vector2 direcao;
    private Rigidbody2D rb;
public void Start()
{
    rb = GetComponent<Rigidbody2D>();
}
public void Update()
{
    direcao.x = Input.GetAxis("Horizontal") * speed;
    rb.velocity = new Vector2(direcao.x, direcao.y);
}
}
