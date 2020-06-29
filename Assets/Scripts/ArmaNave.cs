using UnityEngine;

public class ArmaNave : MonoBehaviour
{
    public GameObject projetil;
    public float intervaloMinimo = 0.5f;
    public float intervaloMaximo = 0.5f;
    public float intervaloInicialMinimo = 1;
    public float intervaloInicialMaximo = 1;
    public Vector3 posicaoArma;
    private float intervaloAtual;

    private void Start()
    {
        intervaloAtual = Random.Range(intervaloInicialMinimo, intervaloInicialMaximo);
    }

    private void Resetar()
    {
        intervaloAtual = Random.Range(intervaloMinimo, intervaloMaximo);
    }

    void Update()
    {
        intervaloAtual -= Time.deltaTime;
        if (intervaloAtual <= 0)
        {
            Resetar();
            Lean.Pool.LeanPool.Spawn(projetil, this.transform.position + posicaoArma, Quaternion.identity);
        }
    }
}
