using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScripTimer : MonoBehaviour
{
    public Text contador;
    public Button botonReinicio;
    private float tiempo = 200f;
    public GameObject ShootPoints;
    public GameObject ShootPoints2;
    public GameObject ShootPoints3;


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
            botonReinicio.gameObject.SetActive(true);
        }

        if (tiempo <= 0)
        {
            ShootPoints.SetActive(false);
            ShootPoints2.SetActive(false);
            ShootPoints3.SetActive(false);
        }
        

    }

    //public void NextSceneLoad()

    //{
    //    if (contador = 170f)
    //    {
    //        SceneManager.LoadScene("Winner");
    //    }

    //}


}
