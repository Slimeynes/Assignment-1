using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuManager : MonoBehaviour {
    public GameObject MainMenu;
    public GameObject Cursor;
    public GameObject[] CursorPositions;
    public GameObject playerSelectIndicator;
    public Text thisText;
    public Camera mainCamera;
    public Camera gameCamera;
    public GameObject playArena;
    public GameObject player01Spawn;
    public GameObject playerPrefab;
    

    private bool onStartGameSelection;
    private bool onePlayer = true;
    //int thisNumber = 0;
    //float thisDecimalNumber = 0.5f;
    //string yourName = "Harry Potter";
    //bool yourValue = true; (or false)




    // Use this for initialization
    void Start () {
        onStartGameSelection = false;
        thisText = playerSelectIndicator.GetComponent<Text>();

    }
	
	// Update is called once per frame
	void Update () {


        if (onStartGameSelection && Input.GetKeyDown("return"))
        {
            playArena.SetActive(true);
            MainMenu.SetActive(false);
            mainCamera.enabled = false;
            gameCamera.enabled = true;
            Instantiate(playerPrefab, player01Spawn.transform.position, Quaternion.identity);


        }

        if (Input.GetKeyDown("up") || Input.GetKeyDown("down"))
        {
            if (onStartGameSelection)
            {
                onStartGameSelection = false;
            }
            else
            {
                onStartGameSelection = true;
            }
        }

        if(onStartGameSelection)
        {
            Cursor.transform.position = CursorPositions[1].transform.position;
        }
        else
        {
            Cursor.transform.position = CursorPositions[0].transform.position;
        }


        if (!onStartGameSelection && Input.GetKeyDown("return"))
        {
            if (onePlayer)
            {
                thisText.text = "2";
                onePlayer = false;
            }
            else
            {
                thisText.text = "1";
                onePlayer = true;
            }
        }

    }
}
