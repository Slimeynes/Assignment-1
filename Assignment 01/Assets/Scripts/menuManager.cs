using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuManager : MonoBehaviour {
    public GameObject maintank;
    public GameObject MainMenu;
    public GameObject Cursor;
    public GameObject[] CursorPositions;
    public GameObject playerSelectIndicator;

    private bool onStartGameSelection;

    //int thisNumber = 0;
    //float thisDecimalNumber = 0.5f;
    //string yourName = "Harry Potter";
    //bool yourValue = true; (or false)




    // Use this for initialization
    void Start () {
        onStartGameSelection = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("space") || Input.GetKey("return"))
        {
            maintank.SetActive(true);
            MainMenu.SetActive(false);

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
    }
}
