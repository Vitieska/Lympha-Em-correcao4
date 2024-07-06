using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tutorial_GameManager : MonoBehaviour
{
    public void comecarEstagio()
    {
        Debug.Log("Começou o estágio.");
        SceneManager.LoadScene(2);
    }
    public void fecharJanela()
    {
        Debug.Log("Fechou e foi para estágio.");

        SceneManager.LoadScene(2);


    }
}
