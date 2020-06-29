using UnityEngine;

public class Background : MonoBehaviour
{
    public Transform[] transforms;
    public float velocidade;
    public float posicaoInicial;
    public float posicaoFinal;

    void FixedUpdate()
    {
        Vector3 deslocamento = new Vector3(0, velocidade * Time.fixedDeltaTime);
        foreach (var t in transforms)
        {
            t.Translate(deslocamento);
            if (t.localPosition.y <= posicaoFinal)
            {
                t.localPosition = new Vector3(t.localPosition.x, posicaoInicial);
            }
        }
    }
}
