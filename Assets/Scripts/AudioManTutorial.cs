using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManTutorial : MonoBehaviour
{
    public AudioSource fonteSFX6;

    public void TocarSom5(AudioClip som5)
    {
        fonteSFX6.PlayOneShot(som5);
    }

}
