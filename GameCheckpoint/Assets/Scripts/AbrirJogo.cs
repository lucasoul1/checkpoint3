using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AbrirJogo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Abrir()
    {
        SceneManager.LoadScene("GameScene");
    }
}
