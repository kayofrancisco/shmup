using UnityEngine;
using UnityEngine.UI;

public class InterfaceVida : MonoBehaviour
{
    public Vida vida;
    public Image imagemVida;

    void Update()
    {
        imagemVida.fillAmount = vida.PorcentagemDeVida();
    }
}
