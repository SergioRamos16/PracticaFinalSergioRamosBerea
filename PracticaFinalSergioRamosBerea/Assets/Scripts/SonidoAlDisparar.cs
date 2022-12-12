using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SonidoAlDisparar : MonoBehaviour
{
    public AudioSource audioDisparo;

    private void Start()
    {
        audioDisparo.Stop();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            audioDisparo.Play();
        }
    }
}