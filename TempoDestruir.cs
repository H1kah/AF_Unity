using UnityEngine;

public class DestruirPorTempo : MonoBehaviour
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
