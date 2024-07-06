using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public int maxLives = 5; // Vidas máximas do SpawnPoint
    private int currentLives; // Vidas atuais do SpawnPoint

    void Start()
    {
        currentLives = maxLives; // Inicializa as vidas atuais com o máximo definido
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PlayerBullet"))
        {
            TakeDamage(); // Chama a função para causar dano ao SpawnPoint
            Destroy(other.gameObject); // Destrói o tiro do jogador ao colidir com o SpawnPoint
        }
    }

    void TakeDamage()
    {
        currentLives--; // Reduz uma vida do SpawnPoint

        if (currentLives <= 0)
        {
            Destroy(gameObject); // Destroi o SpawnPoint se suas vidas chegarem a zero
            // Aqui você pode adicionar efeitos visuais, som de explosão, etc.
        }
    }
}

