using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShootPoint : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform[] shootPointPosition;
    public float tiempoParaApagarse = 4f;
   
    public float timeBerweenShoots = 4;
    private float timeSinceLastShoot = 0;
   
    private void Update()
    {
        timeSinceLastShoot += Time.deltaTime;
        if (timeSinceLastShoot > timeBerweenShoots)
        {
            int rand = Random.Range(0, shootPointPosition.Length);

            timeSinceLastShoot = 0;
            Instantiate(bulletPrefab, shootPointPosition[rand].position, shootPointPosition[rand].rotation);
        }
    }
    
    void TiempoParaApagarse() 
    {
        if (tiempoParaApagarse < 0)
        {
            bulletPrefab.SetActive(false);
        }
    }
   



   
}