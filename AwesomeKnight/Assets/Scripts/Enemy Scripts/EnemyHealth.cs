using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    public float health = 100f;

    public void TakeDamage(float amount) {
        health -= amount;

        //print("Enemy Took Damage, health is " + health);

        if(health <= 0) { 
            
        }
    }
}
