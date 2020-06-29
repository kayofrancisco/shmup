using UnityEngine;

public class CriadorInimigos : MonoBehaviour
{
    public GameObject[] possibilidades;
    public float intervalo = 5;
    public float intervaloInicial = 3;
    public float duracao = 7;
    private float intervaloAtual;

    void Start()
    {
        intervaloAtual = intervaloInicial;
    }

    void Update()
    {
        intervaloAtual -= Time.deltaTime;
        if (intervaloAtual <= 0)
        {
            intervaloAtual = intervalo;
            CriarInimigo();
        }
    }

    private void CriarInimigo()
    {
        GameObject inimigoSorteado = possibilidades[Random.Range(0, possibilidades.Length)];
        GameObject inimigoCriado = GameObject.Instantiate(inimigoSorteado, transform.position, Quaternion.identity);
        GameObject.Destroy(inimigoCriado, 7);
    }
}
