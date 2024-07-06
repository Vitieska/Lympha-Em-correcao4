using UnityEngine;

public class Player : MonoBehaviour
{
    Animator myAnimation;
    private GameObject currentEnemy;

    void Start()
    {
        myAnimation = GetComponent<Animator>();
    }

    void Update()
    {
        {
            Attack();
        }

        if (Input.GetKeyDown(KeyCode.Space) && currentEnemy != null)
        {
            DevourEnemy();
        }
    }

    void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Space) && currentEnemy != null)
        {
            myAnimation.SetBool("Attack", true);
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            currentEnemy = collision.gameObject;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            currentEnemy = null;
        }
    }

    private void DevourEnemy()
    {
        Destroy(currentEnemy);
        // Adicione aqui outros efeitos, como aumentar o score, tocar som, etc.
    }
}

