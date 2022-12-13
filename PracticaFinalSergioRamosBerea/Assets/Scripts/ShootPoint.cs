using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShootPoint : MonoBehaviour
{
    public GameObject[] bulletPrefab;
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
            int randPref = Random.Range(0, bulletPrefab.Length);

            timeSinceLastShoot = 0;
            Instantiate(bulletPrefab[randPref], shootPointPosition[rand].position, shootPointPosition[rand].rotation);
        }
    }

    private void TiempoParaApagarse()
    {
        if (tiempoParaApagarse < 0)
        {
            bulletPrefab[bulletPrefab.Length].SetActive(false);
        }
    }
}