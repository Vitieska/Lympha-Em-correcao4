using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManDefeat : MonoBehaviour
{
    public AudioSource fonteSFX4;

    public void TocarSom3(AudioClip som3)
    {
        fonteSFX4.PlayOneShot(som3);
    }

}
