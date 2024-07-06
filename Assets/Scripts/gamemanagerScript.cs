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
    public TMP_Text victoryText; // Refer�ncia ao texto de vit�ria na UI

    void Start()
    {
        if (victoryText != null)
        {
            victoryText.gameObject.SetActive(false); // Certifique-se de que o texto de vit�ria est� desativado no in�cio
        }
    }

    void Update()
    {
        CheckVictoryCondition();
    }

    public void comecarJogo()
    {
        Debug.Log("Come�ou o jogo.");
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
                return; // Se encontrar qualquer spawner ainda ativo, sai da fun��o
            }
        }

        // Se todos os spawners foram destru�dos
        if (victoryText != null)
        {
            victoryText.gameObject.SetActive(true);
        }
    }
}