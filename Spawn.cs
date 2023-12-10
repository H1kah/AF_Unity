using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject objetoPrefab;
    public float raioSpawn = 3f;
    public float intervaloMinimo = 2f;
    public float intervaloMaximo = 5f;

    void Start()
    {

        Invoke("SpawnObjeto", Random.Range(intervaloMinimo, intervaloMaximo));
    }

    void SpawnObjeto()
    {

        float anguloAleatorio = Random.Range(0f, 2f * Mathf.PI);

        Vector2 spawnOffset = new Vector2(Mathf.Cos(anguloAleatorio) * raioSpawn, Mathf.Sin(anguloAleatorio) * raioSpawn);
        Vector2 spawnPosition = (Vector2)transform.position + spawnOffset;

        GameObject novoObjeto = Instantiate(objetoPrefab, spawnPosition, Quaternion.identity);

        Invoke("SpawnObjeto", Random.Range(intervaloMinimo, intervaloMaximo));
    }
}
