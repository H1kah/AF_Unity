using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviment : MonoBehaviour
{
    public int vida;

    public float speed;
    public float pulo;
    
    public Vector2 direcao;
    
    private Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        direcao.x = Input.GetAxis("Horizontal") * speed;
        rb.AddForce(direcao, ForceMode2D.Force);

        if (direcao.x < 0f)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 180f, 0f));
        }
        if (direcao.x > 0f)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0f, 0f));
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0, 1) * pulo, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log(other.gameObject.tag);

        if (other.gameObject.CompareTag("Enemy"))
        {
            vida -= 1;

            if (vida == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
