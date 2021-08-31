using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Boss_State { 
    NONE,
    IDLE,
    PAUSE,
    ATTACK,
    DEATH
}

public class BossStateChecker : MonoBehaviour {

    private Transform playerTarget;
    private Boss_State boss_State = Boss_State.NONE;
    private float distanceToTarget;

    private EnemyHealth bossHealth;

    public GameOverScript gameOverScript;

    void Awake() {
        playerTarget = GameObject.FindGameObjectWithTag("Player").transform;
        bossHealth = GetComponent<EnemyHealth>();
    }

    void Update() {
        if(playerTarget) { 
            SetState();
        }
    }

    public void GameOver() {
        gameOverScript.Setup();
    }

    void SetState() {
        distanceToTarget = Vector3.Distance(transform.position, playerTarget.position);

        if(boss_State != Boss_State.DEATH) { 
            if(distanceToTarget > 3 && distanceToTarget <= 15f) {
                boss_State = Boss_State.PAUSE;
            } else if (distanceToTarget > 15f) {
                boss_State = Boss_State.IDLE;
            } else if(distanceToTarget <= 3f) {
                boss_State = Boss_State.ATTACK;
            } else {
                boss_State = Boss_State.NONE;
            }

            if(bossHealth.health <= 0f) {
                boss_State = Boss_State.DEATH;
                GameOver();
            }
        }
    }

    public Boss_State BossState { 
        get { return boss_State; }
        set { boss_State = value; }
    }
}
