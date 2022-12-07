using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SonidoAlDisparar : MonoBehaviour
{
    
    public AudioSource auidoDisparo;

    
    
    private void OnMouseDown()
    {
        auidoDisparo.Play();
    }
}