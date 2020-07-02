using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Global
{
    public static bool keyObtained = false;
    public static bool playerDead = false;
    
}

public class Character2DController : MonoBehaviour
{
    public float Movementspeed;


    private void Update()
    {
        var movement = Input.GetAxis("Horizontal"); //left and right arrow key 
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * Movementspeed; //changing only the x axis

     

    }

}



