using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPoint : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform[] shootPointPosition;

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
}