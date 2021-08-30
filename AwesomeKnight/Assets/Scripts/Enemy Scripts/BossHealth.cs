using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealth : MonoBehaviour {

    public float health = 200f;

    public Image health_Img;

    public GameOverScript gameOverScript;

    public void TakeDamage(float amount) {
        health -= amount;

        health_Img.fillAmount = health / 200f;

        if(health <= 0) {
            GameOver();
        }
    }

    public void GameOver() {
        gameOverScript.Setup();
    }
}
