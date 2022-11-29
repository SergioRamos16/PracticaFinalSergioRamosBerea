using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : Health
{
    public Collider2D enemyCollider;
    public GameObject gameObject;

    private void Awake()
    {
        enemyCollider = GetComponent<Collider2D>();
    }

    public override void Die()
    {
        Destroy(gameObject);
    }
}