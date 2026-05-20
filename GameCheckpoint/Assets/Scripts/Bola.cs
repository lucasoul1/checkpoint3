using System.Security.Cryptography;
using UnityEngine;

public class Bola : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private float velocidade = 3f;
    float velocidade_x = 0;
    float velocidade_y = 0;
    void Start()
    {
        velocidade_x = velocidade;
        velocidade_y = -velocidade;
        transform.position = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(velocidade_x * Time.deltaTime, velocidade_y * Time.deltaTime, 0f);
        if(Pontos.pontos == 9)
        {
            transform.position = Vector2.zero;
            velocidade_x = 0;
            velocidade_y = 0;
        }
    }   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "WallX")
        {
            velocidade_x *= -1;
        }
        else if (collision.gameObject.tag == "WallY")
        {
            velocidade_y *= -1;
        }
        else if (collision.gameObject.tag == "Player")
        {
            velocidade_y *= -1;
        }
        else if (collision.gameObject.tag == "Bloco")
        {
            velocidade_y *= -1;
            Pontos.pontos++;
            GetComponent<SpriteRenderer>().color = collision.gameObject.GetComponent<SpriteRenderer>().color;
            Destroy(collision.gameObject);
        }
    }
}
