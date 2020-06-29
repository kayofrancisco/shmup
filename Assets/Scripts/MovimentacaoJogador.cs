using UnityEngine;

public class MovimentacaoJogador : MonoBehaviour
{
    public Vector2 velocidade;
    public float limiteX;
    private Vector2 velocidadeAtual;

    void FixedUpdate()
    {
        transform.Translate(velocidadeAtual * Time.fixedDeltaTime);
        if (transform.localPosition.x > limiteX)
        {
            transform.localPosition = new Vector2(limiteX, transform.localPosition.y);
            Parar();
        }
        if (transform.localPosition.x < -limiteX)
        {
            transform.localPosition = new Vector2(-limiteX, transform.localPosition.y);
            Parar();
        }
    }

    public void MoverEsquerda()
    {
        velocidadeAtual = velocidade * -1;
    }

    public void MoverDireita()
    {
        velocidadeAtual = velocidade;
    }

    public void Parar()
    {
        velocidadeAtual = Vector2.zero;
    }
}
