using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float detectionRadius = 5f;   // Raio de detec��o do jogador
    public Transform player;

    public playerHealthScript playerHealth;

    private Rigidbody2D rb;
    private Vector2 movement;

   /* private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerHealth.TakeDamage(1);
        }
    }*/
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<PlayerMovement>().transform;
    }

    void Update()
    {
        // Verifica a dist�ncia do jogador
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);

        if (distanceToPlayer <= detectionRadius)
        {
            // Verifica a posi��o do jogador
            Vector3 direction = player.position - transform.position;
            direction.Normalize();
            movement = direction;
        }
        else
        {
            movement = Vector2.zero;  // Se o jogador estiver fora do raio de detec��o, o inimigo n�o se move
        }
    }

    void FixedUpdate()
    {
        // Move o inimigo na dire��o do jogador
        rb.MovePosition((Vector2)transform.position + (movement * moveSpeed * Time.fixedDeltaTime));
    }

    void OnDrawGizmosSelected()
    {
        // Desenha o raio de detec��o no Editor da Unity
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectionRadius);
    }

    void OnDestroy()
    {
        gamemanagerScript gameManager = FindObjectOfType<gamemanagerScript>();
        if (gameManager != null)
        {
            // Atualiza o array no gamemanagerScript para remover refer�ncias nulas
            gameManager.enemySpawners = System.Array.FindAll(gameManager.enemySpawners, spawner => spawner != this);
        }
    }

}
