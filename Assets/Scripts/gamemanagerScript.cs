using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
// Para usar UI elements como texto

public class gamemanagerScript : MonoBehaviour
{
    public EnemySpawner[] enemySpawners; // Array de EnemySpawners
    public TMP_Text victoryText; // Referência ao texto de vitória na UI

    void Start()
    {
        if (victoryText != null)
        {
            victoryText.gameObject.SetActive(false); // Certifique-se de que o texto de vitória está desativado no início
        }
    }

    void Update()
    {
        CheckVictoryCondition();
    }

    public void comecarJogo()
    {
        Debug.Log("Começou o jogo.");
        SceneManager.LoadScene(1);
    }

    public void sairJogo()
    {
        Debug.Log("Saiu do jogo.");
        Application.Quit();
    }

    void CheckVictoryCondition()
    {
        foreach (EnemySpawner spawner in enemySpawners)
        {
            if (spawner != null)
            {
                return; // Se encontrar qualquer spawner ainda ativo, sai da função
            }
        }

        // Se todos os spawners foram destruídos
        if (victoryText != null)
        {
            victoryText.gameObject.SetActive(true);
        }
    }
}