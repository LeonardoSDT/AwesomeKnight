using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public float health = 100f;

    private bool isShielded;

    private Animator anim;

    void Awake() {
        anim = GetComponent<Animator>();
    }

    public bool Shielded { 
        get { return isShielded; }
        set { isShielded = value; }
    }

    public void TakeDamage(float amount) {

        if(!isShielded) { 
            health -= amount;

            if(health <= 0) {
                anim.SetBool("Death", true);

                if(!anim.IsInTransition(0) && anim.GetCurrentAnimatorStateInfo(0).IsName("Death") && anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.65) {
                    // Destroy player
                    Destroy(gameObject);
                }
            }
        }        
    }
}