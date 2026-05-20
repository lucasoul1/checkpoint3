using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Pontos : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public static int pontos;
    void Start()
    {
        pontos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        print(pontos);
    }
}
