using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuManager : MonoBehaviour {
    public GameObject player;
    public GameObject mainMenu;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("Space") || Input.GetKey("return"))
        {
            player.SetActive(true);
            mainMenu.SetActive(false);

        }

	}
}
