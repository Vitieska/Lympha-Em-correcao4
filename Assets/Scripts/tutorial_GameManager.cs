using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tutorial_GameManager : MonoBehaviour
{
    public void comecarEstagio()
    {
        Debug.Log("Come�ou o est�gio.");
        SceneManager.LoadScene(2);
    }
    public void fecharJanela()
    {
        Debug.Log("Fechou e foi para est�gio.");

        SceneManager.LoadScene(2);


    }
}
