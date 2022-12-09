using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SonidoAlDisparar : MonoBehaviour
{
    public AudioSource audioDisparo;
    

  void Start() 
  {
     audioDisparo.Stop();
  }
  void Update() 
  {
    if (Input.GetKeyDown(KeyCode.Mouse0))
    {
        audioDisparo.Play();
    }
    
  }
}