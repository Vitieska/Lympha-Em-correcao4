using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10f;
    public float lifetime = 2f;

    void Start()
    {
        // Destroi o projétil após o tempo de vida especificado
        Destroy(gameObject, lifetime);
    }

    void Update()
    {
        // Move o projétil para frente no eixo Y
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Adicione lógica para quando o projétil colidir com algo
        Destroy(gameObject);
    }
}
