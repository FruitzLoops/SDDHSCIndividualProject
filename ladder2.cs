using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladder2 : MonoBehaviour
{
    public float ladderSpeed = 20;

    private bool ladderRequest;
    private bool onLadderStill;

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
   
            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow)) //up or down arrow key down
            {
                ladderRequest = true;
            }
            else //player is not moving but is still on the ladder
            {
                onLadderStill = true; 
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) //player isn't touching ladder anymore
        {
            ladderRequest = false; 
            onLadderStill = false;
        }
    }

    void FixedUpdate()
    {
        if (ladderRequest)
        {
            var movement = Input.GetAxis("Vertical");
            GameObject.FindGameObjectWithTag("Player").transform.position += new Vector3(0, movement, 0) * Time.deltaTime * ladderSpeed;
            //player will move along the y axis depending on whether up or down arrow key is pressed
        }

        if (onLadderStill)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            // player will not move
        }
    }
}


