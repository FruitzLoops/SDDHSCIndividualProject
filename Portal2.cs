using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal2 : MonoBehaviour
{
    private Transform destination;
    public string bluPortName;

    void Start()
    {
        destination = GameObject.Find(bluPortName).GetComponent<Transform>();
        // if portal is red, destination is the blue portal
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        other.transform.position = new Vector2(destination.position.x, destination.position.y);
        // position is now the desination
    }

}





