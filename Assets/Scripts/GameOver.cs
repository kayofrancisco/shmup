using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject jogador;
    public GameObject telaDerrota;

    void Update()
    {
        if (jogador == null)
        {
            telaDerrota.SetActive(true);
        }
        else
        {
            telaDerrota.SetActive(false);
        }
    }
}
