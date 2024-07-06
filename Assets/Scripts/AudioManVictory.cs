using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManVictory : MonoBehaviour
{
    public AudioSource fonteSFX3;

    public void TocarSom2(AudioClip som2)
    {
        fonteSFX3.PlayOneShot(som2);
    }
}
