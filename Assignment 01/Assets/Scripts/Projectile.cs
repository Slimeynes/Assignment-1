using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject greyExplosion;
    public GameObject Flag;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == null)
        {return;}


        if (other.gameObject.CompareTag("Player"))
        {
            // For now, don't do anything
        }

        else if (other.gameObject.CompareTag("Flag"))
            { 
            Debug.Log ("we hit the flag");
            Instantiate(greyExplosion, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
            GameManager.flagDestroyed();
        }

        else if (other.gameObject != null)
        {
            // We hit something other than the player
           
            Instantiate(greyExplosion, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
