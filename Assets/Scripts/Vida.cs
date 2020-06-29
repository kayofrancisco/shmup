using UnityEngine;

public class Vida : MonoBehaviour
{
    public int valorAtual;
    public int valorMaximo;
    public bool destruirEmZero = true;
    public GameObject efeitoMorte;

    private void OnEnable()
    {
        valorAtual = valorMaximo;
    }

    public void CausarDano(int quantidade)
    {
        valorAtual = Mathf.Clamp(valorAtual - quantidade, 0, valorMaximo);
        if (valorAtual == 0)
        {
            if (destruirEmZero)
            {
                if (efeitoMorte)
                {
                    Lean.Pool.LeanPool.Spawn(efeitoMorte, transform.position, Quaternion.identity);
                }
                GameObject.Destroy(gameObject);
            }
        }
    }

    public float PorcentagemDeVida()
    {
        return (float)valorAtual / (float)valorMaximo;
    }
}
