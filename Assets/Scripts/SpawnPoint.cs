using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public int maxLives = 5; // Vidas m�ximas do SpawnPoint
    private int currentLives; // Vidas atuais do SpawnPoint

    void Start()
    {
        currentLives = maxLives; // Inicializa as vidas atuais com o m�ximo definido
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PlayerBullet"))
        {
            TakeDamage(); // Chama a fun��o para causar dano ao SpawnPoint
            Destroy(other.gameObject); // Destr�i o tiro do jogador ao colidir com o SpawnPoint
        }
    }

    void TakeDamage()
    {
        currentLives--; // Reduz uma vida do SpawnPoint

        if (currentLives <= 0)
        {
            Destroy(gameObject); // Destroi o SpawnPoint se suas vidas chegarem a zero
            // Aqui voc� pode adicionar efeitos visuais, som de explos�o, etc.
        }
    }
}

