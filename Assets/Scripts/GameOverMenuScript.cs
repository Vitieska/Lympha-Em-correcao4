using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenuScript : MonoBehaviour
{
    public void reiniciarEstagio()
    {
        Debug.Log("Recomeçou estágio.");
        SceneManager.LoadScene(1);
    }
    public void voltarMenu()
    {
        Debug.Log("Voltou para o Menu Inicial.");
        SceneManager.LoadScene(0);
    }
}
