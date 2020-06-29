using UnityEngine;

public class SpriteAleatorio : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] spritesPossiveis;

    private void OnEnable()
    {
        spriteRenderer.sprite = spritesPossiveis[Random.Range(0, spritesPossiveis.Length)];
    }
}
