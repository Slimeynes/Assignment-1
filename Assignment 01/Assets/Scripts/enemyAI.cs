using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI : MonoBehaviour
{
    bool canFire = false;
    bool canTurn = false;
    int chanceToFire = 30;
    int chanceToTurn = 40;
    int randomNumber = 0;
    DateTime timeSinceLastDecision = DateTime.Now;
    TimeSpan AICooldown = TimeSpan.FromSeconds(1);
    Rigidbody2D enemyRB;
    SpriteRenderer enemySR;
    Animator enemyAN;
    public enemyDirection AIDirection = enemyDirection.down;

    // Start is called before the first frame update
    void Start()
    {
        enemyRB = GetComponent<Rigidbody2D>();
        enemySR = GetComponent<SpriteRenderer>();
        enemyAN = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (AIDirection)
        {
            case enemyDirection.up:
                break;
            case enemyDirection.down:
                break;
                enemyRB.velocity = new Vector2(0, -2);
            case enemyDirection.left:
                break;
            case enemyDirection.right:
                break;
            default:
                break;

        }

        if (DateTime.Now > (timeSinceLastDecision + AICooldown))
        {
            //Debug.Log("Enemy can make decision");
            timeSinceLastDecision = DateTime.Now;
        }
        else
        {
            return;
        }

        // Chance to fire?
        randomNumber = UnityEngine.Random.Range(0, 100);

        if (randomNumber < chanceToFire)
        {
            canFire = true;
        }



        if (canFire)
        {
            fireProjectile();

        }


        if (canTurn)
        {
            turnTank();

        }
    }
    private void fireProjectile()
    {
        Debug.Log("Enemy tank fires!");
        canFire = false;

    }
    private void turnTank()
    {
        canTurn = false;
    }
    public enum enemyDirection
    {
             up = 1,
            down,
            left,
            right,
    }
        

        


}
