using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enddoor : MonoBehaviour
{

    public static bool lvlFin = false;

    private void Start()
    {
        lvlFin = false;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) //did player enter door
        {
            if(Global.keyObtained == true) //does player have key
            {
                lvlFin = true; //level is finished
            }
        }
    }
}