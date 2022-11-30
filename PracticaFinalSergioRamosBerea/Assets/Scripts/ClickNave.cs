using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickNave : MonoBehaviour
{
    public int currentNumberOfPoints;
    public Text pointText;
    public int damageDealt = 1;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 origin = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 dir = Vector2.zero;
            RaycastHit2D hit = Physics2D.Raycast(origin, dir);
            if (hit)
            {
                Debug.Log("Has disparado a la nave");

                string hitTag = hit.collider.gameObject.tag;
                switch (hitTag)
                {
                    case "Alien":
                        GetPoints(1);
                        break;

                    case "Nave":
                        GetPoints(1);
                        break;

                    default:
                        break;
                }
                Health health = hit.collider.gameObject.GetComponent<Health>();
                if (health != null)
                {
                    health.TakeDamage(damageDealt);
                }
            }
        }
    }

    public void GetPoints(int pointAmount)
    {
        pointText.text = currentNumberOfPoints.ToString();
        currentNumberOfPoints += pointAmount;

        if (currentNumberOfPoints == 1)
        {
            Debug.Log("Has destruido una nave, tienes " + currentNumberOfPoints + " punto.");
            pointText.text = currentNumberOfPoints.ToString();
        }
        else
        {
            Debug.Log("Has destruido una nave, tienes " + currentNumberOfPoints + " puntos.");
            pointText.text = currentNumberOfPoints.ToString();
        }
    }
}