using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus;

public class target : MonoBehaviour {

    public float health = 50f;

    public void TakeDamage (float amount)
    {
        health -= amount;
        if(health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

	
}
