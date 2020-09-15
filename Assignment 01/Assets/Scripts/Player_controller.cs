using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controller : MonoBehaviour {
    Rigidbody2D rb2d;


	// Use this for initialization
	void Start () {
        Debug.Log("Test player manager reporting!");
        rb2d = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {
        rb2d.velocity = new Vector2(0,0);
        if(Input.GetKey("w")) { 
       rb2d.velocity = new Vector2(0, 10);
        }
        else if (Input.GetKey("s"))
        {
            rb2d.velocity = new Vector2(0, -10);
        }
        else if (Input.GetKey("a"))
        {
            rb2d.velocity = new Vector2(-10, 0);
        }
        else if (Input.GetKey("d"))
        {
            rb2d.velocity = new Vector2(10, 0);
        }
    }
}
