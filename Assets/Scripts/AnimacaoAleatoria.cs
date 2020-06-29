using UnityEngine;

public class AnimacaoAleatoria : MonoBehaviour
{
    public Animation alvo;
    public AnimationClip[] animacoesPossiveis;

    void OnEnable()
    {
        AnimationClip animacaoSorteada = animacoesPossiveis[Random.Range(0, animacoesPossiveis.Length)];
        alvo.AddClip(animacaoSorteada, animacaoSorteada.name);
        alvo.clip = animacaoSorteada;
        alvo.Play();
    }
}
