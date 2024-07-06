using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManStaegScript : MonoBehaviour
{
    public AudioSource fonteSFX2;

    public void TocarSom1(AudioClip som1)
    {
        fonteSFX2.PlayOneShot(som1);
    }

}
