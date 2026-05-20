using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private float velocidade = 4f;
    void Start()
    {
        transform.position = new Vector2 (0f, -4f);
    }

    void Update()
    {
        float mover_x = Input.GetAxisRaw("Horizontal") * velocidade * Time.deltaTime;

        transform.Translate(mover_x, 0f, 0f);
    }
}
