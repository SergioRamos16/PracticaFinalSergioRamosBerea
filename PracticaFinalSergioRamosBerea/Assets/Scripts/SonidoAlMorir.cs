using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoAlMorir : MonoBehaviour
{
    public AudioSource sonidoAlMorir;
    public AudioClip myAudio;

    private void OnMouseDown()
    {
        sonidoAlMorir.Play();
    }
}