using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public float speed = 10;
    private string playerTag = "Player";
    private string worldTag = "World";

    private void Update()
    {
        transform.position += transform.right * Time.deltaTime * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(playerTag))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag(worldTag))
        {
            FindObjectOfType<LevelManager>();
        }
    }
}