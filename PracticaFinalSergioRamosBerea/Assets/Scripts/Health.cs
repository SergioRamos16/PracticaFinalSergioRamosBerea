using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int MaxHealth = 3;
    private int currentHealth;

    private Vector3 InitialPosition;

    private void Start()
    {
        InitialPosition = transform.position;
        currentHealth = MaxHealth;
    }

    public void TakeDamage(int damageTaken)
    {
        currentHealth -= damageTaken;

        if (currentHealth <= 0)
        {
            //Debug.Log("estoy muerto");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Die();
        }
        else
        {
            Debug.Log("me han echo daño, salud restante " + currentHealth);
        }
    }

    public virtual void Die()
    {
    }
}