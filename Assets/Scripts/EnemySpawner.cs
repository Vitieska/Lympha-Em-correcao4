using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform[] spawnPoints;
    public float spawnInterval = 5f;
    public float spawnRadius = 5f;

    private float timer;

    void Start()
    {
        timer = spawnInterval;
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            SpawnEnemy();
            timer = spawnInterval;
        }
    }

    void SpawnEnemy()
    {
        if (spawnPoints.Length == 0)
        {
            Debug.LogWarning("Nenhum ponto de spawn configurado.");
            return;
        }

        int spawnIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[spawnIndex];

        if (spawnPoint != null)
        {
            Vector3 randomPosition = spawnPoint.position + (Random.insideUnitSphere * spawnRadius);
            randomPosition.y = spawnPoint.position.y; // Preserva a altura do ponto de spawn original

            Instantiate(enemyPrefab, randomPosition, spawnPoint.rotation);
        }
        else
        {
            Debug.LogWarning("O ponto de spawn selecionado foi destruído.");
        }
    }

    void OnDestroy()
    {
        gamemanagerScript gameManager = FindObjectOfType<gamemanagerScript>();
        if (gameManager != null)
        {
            // Atualiza o array no gamemanagerScript para remover referências nulas
            List<EnemySpawner> updatedSpawners = new List<EnemySpawner>(gameManager.enemySpawners);
            updatedSpawners.Remove(this);
            gameManager.enemySpawners = updatedSpawners.ToArray();
        }
    }
}