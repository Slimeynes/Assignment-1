using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controller : MonoBehaviour {
    Rigidbody2D rb2d;
    SpriteRenderer spriteRen;
    Animator tankAnim;
    public GameObject basicBullet;
    public tankDirection playerDirection = tankDirection.up;
    



    // Use this for initialization
    void Start () {
        Debug.Log("Test player manager reporting!");
        rb2d = GetComponent<Rigidbody2D>();
        spriteRen = GetComponent<SpriteRenderer>();
        tankAnim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        rb2d.velocity = new Vector2(0,0);
        if(Input.GetKey("w")) {
            spriteRen.flipY = false;
            tankAnim.Play("basicTankUp");
       rb2d.velocity = new Vector2(0, 5);
            playerDirection = tankDirection.up;
        }
        else if (Input.GetKey("s"))
        {
            rb2d.velocity = new Vector2(0, -5);
            spriteRen.flipY = true;
            tankAnim.Play("basicTankUp");
            playerDirection = tankDirection.down;

        }
        else if (Input.GetKey("a"))
        {
            rb2d.velocity = new Vector2(-5, 0);
            spriteRen.flipX = true;
            tankAnim.Play("basicTankRight");
            playerDirection = tankDirection.left;

        }
        else if (Input.GetKey("d"))
        {
            rb2d.velocity = new Vector2(5, 0);
           spriteRen.flipX = false;
            tankAnim.Play("basicTankRight");
            playerDirection = tankDirection.right;
        }
        else
        {
            rb2d.velocity = new Vector2(0, 0);
        }

        if (Input.GetKeyDown("space"))
        {
            // Debug.Log("player tries fire");
            switch (playerDirection)
            {
                case tankDirection.up:
                    // Fire up
                    // Instantiate the projectile from a prefab!
                    GameObject thisProjectile = Instantiate(basicBullet, transform.position, Quaternion.identity);
                    Rigidbody2D projectileRB = thisProjectile.GetComponent<Rigidbody2D>();
                    projectileRB.velocity = new Vector2(0, 10);
                    break;

                case tankDirection.down:
                    // Fire Down
                    // Instantiate the projectile from a prefab!
                    GameObject thisProjectileDown = Instantiate(basicBullet, transform.position, Quaternion.Euler(0f, 0f, 180f));
                    Rigidbody2D projectileRBDown = thisProjectileDown.GetComponent<Rigidbody2D>();
                    projectileRBDown.velocity = new Vector2(0, -10);
                    break;

                case tankDirection.right:
                    // Fire right
                    // Instantiate the projectile from a prefab!
                    GameObject thisProjectileRight = Instantiate(basicBullet, transform.position, Quaternion.Euler(0f, 0f, -90f));
                    Rigidbody2D projectileRBRight = thisProjectileRight.GetComponent<Rigidbody2D>();
                    projectileRBRight.velocity = new Vector2(10, 0);
                    break;
                case tankDirection.left:
                    // Fire left
                    // Instantiate the projectile from a prefab!
                    GameObject thisProjectileLeft = Instantiate(basicBullet, transform.position, Quaternion.Euler(0f, 0f, 90f));
                    Rigidbody2D projectileRBLeft = thisProjectileLeft.GetComponent<Rigidbody2D>();
                    projectileRBLeft.velocity = new Vector2(-10, 0);
                    break;

                default:
                    Debug.Log("playerDirection was invalid");
                    break;
            }

        }
    }

    public enum tankDirection
    {
        up = 1,
        down,
        right,
        left,
    }


}


