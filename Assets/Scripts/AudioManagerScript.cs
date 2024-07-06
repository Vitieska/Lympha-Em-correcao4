using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerScript : MonoBehaviour
{
    //static AudioManagerScript instance;
    public AudioSource fonteSFX;

    /*private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else { 
        instance = this;
        DontDestroyOnLoad(gameObject);
        }
    }*/

    public void TocarSom(AudioClip som)
    {
       fonteSFX.PlayOneShot(som);
    }
}
