using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health;
    public float MaxHitPoints = 8f;
    

    void Start()
    {
        health = MaxHitPoints;

    }

    public void TakeDamage(int damage)
    {
       
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        Debug.Log("damage Taken");
    }
}
