using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScripTimer : MonoBehaviour
{
    public Text contador;
    private float tiempo = 60f;
    
    
    void Start()
    {
       
        contador.text = "" + tiempo;
    }

 
    void Update()
    {
        tiempo -= Time.deltaTime;
        contador.text = "" + tiempo.ToString("f0");
        if (tiempo<=0)
        {
            contador.text = "0";
            
        }
    }
   
}
