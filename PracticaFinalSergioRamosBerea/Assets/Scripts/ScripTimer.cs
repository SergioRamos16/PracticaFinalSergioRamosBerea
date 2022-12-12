using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScripTimer : MonoBehaviour
{
    public Text contador;
    private float tiempo = 10f;

    //public Button botonReinicio;

    //public GameObject ShootPoints;
    //public GameObject ShootPoints2;
    //public GameObject ShootPoints3;

    //private void Start()
    //{
    //    contador.text = "" + tiempo;
    //}

    private void Update()
    {
        if (tiempo <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        tiempo -= Time.deltaTime;
        contador.text = "" + tiempo.ToString("f0");
        //if (tiempo <= 0)
        //{
        //    contador.text = "0";
        //    botonReinicio.gameObject.SetActive(true);
        //}

        //if (tiempo <= 0)
        //{
        //    ShootPoints.SetActive(false);
        //    ShootPoints2.SetActive(false);
        //    ShootPoints3.SetActive(false);
        //}
    }
}