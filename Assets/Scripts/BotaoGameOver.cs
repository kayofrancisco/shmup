using UnityEngine;
using UnityEngine.SceneManagement;

public class BotaoGameOver : MonoBehaviour
{
    public void ReiniciarJogo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
