using UnityEngine;

public class TempoDestruir : MonoBehaviour
{
    public float tempoParaDestruir = 0f;

    void Start()
    {
        Invoke("DestruirObjeto", tempoParaDestruir);
    }

    void DestruirObjeto()
    {
        Destroy(gameObject);
    }
}
