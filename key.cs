using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class key : MonoBehaviour
{
    void Start()
    {

        gameObject.SetActive(true);
    }

   void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Global.keyObtained = true;  //global variable enddoor.cs will use
            gameObject.SetActive(false); //key disappears
            
        }
    }
}


