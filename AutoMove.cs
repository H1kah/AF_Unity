using UnityEngine;

public class AutoMove : MonoBehaviour
{
    public float speed = 5f;
    public Vector2 moveDirection = Vector2.right;


    void Update()
    {
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }
}
