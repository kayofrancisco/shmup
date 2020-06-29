using UnityEngine;
using UnityEngine.SceneManagement;

public class BotaoCarregaScene : MonoBehaviour
{
    public void Carregar(int index)
    {
        SceneManager.LoadScene(index);
    }
}
