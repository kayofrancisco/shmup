using UnityEngine;

public class Projetil : MonoBehaviour
{
    public Vector2 velocidade;
    public string[] tagsColisao;
    public float duracaoEmSegundos = 5;
    public int quantidadeDano = 20;
    public GameObject efeito;
    private float duracaoAtual;

    private void OnEnable()
    {
        duracaoAtual = duracaoEmSegundos;
    }

    void FixedUpdate()
    {
        this.transform.Translate(velocidade * Time.fixedDeltaTime);
        duracaoAtual -= Time.fixedDeltaTime;
        if (duracaoAtual <= 0)
        {
            Despawn();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        foreach (var tag in tagsColisao)
        {
            if (collision.gameObject.CompareTag(tag))
            {
                Vida vida = collision.GetComponent<Vida>();
                if (vida != null)
                {
                    vida.CausarDano(quantidadeDano);
                }
                Despawn();
            }
        }
    }

    private void Despawn()
    {
        if (efeito != null)
        {
            Lean.Pool.LeanPool.Spawn(efeito, transform.position, Quaternion.identity);
        }
        Lean.Pool.LeanPool.Despawn(gameObject);
    }
}
