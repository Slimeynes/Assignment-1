using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameObject mainMenu;
    public static GameObject playArena;
    public static GameObject endGameScreen;



    // Start is called before the first frame update
    void Start()
    {
        mainMenu = GameObject.FindGameObjectWithTag("mainMenu");

        playArena = GameObject.FindGameObjectWithTag("playArena");
        playArena.SetActive(false);
        endGameScreen = GameObject.FindGameObjectWithTag("endGameScreen");
        endGameScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void flagDestroyed()
    {  
        GameObject Flag = GameObject.FindGameObjectWithTag("Flag");
        if (Flag != null)
        {
            SpriteRenderer SR = Flag.GetComponent<SpriteRenderer>();

            SR.sprite = Resources.Load<Sprite>("flagDead");
        }
        else
        {
            Debug.Log("could not find the flag!!!");
        }

        endGameScreen.SetActive(true);
        playArena.SetActive(false);

    }
}
