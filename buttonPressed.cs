using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class SwitchdoorVar
{
    public static bool buttonDown = false;
}

public class buttonPressed : MonoBehaviour
{
    [SerializeField] private buttonAnimated button;

    public GameObject openDoor;
    public GameObject closedDoor;

    private void Start()
    {
        openDoor.SetActive(false);
        closedDoor.SetActive(true);
        // door is closed
    }


    void OnTriggerEnter2D(Collider2D other) //button pressed
    {
        button.ButtonDown();
        openDoor.SetActive(true);
        closedDoor.SetActive(false);
        //door is open

    }

    void OnTriggerExit2D(Collider2D other) //button released
    {
        button.ButtonUp(); 
        openDoor.SetActive(false);
        closedDoor.SetActive(true);
        //door is closed
    }

    
}






