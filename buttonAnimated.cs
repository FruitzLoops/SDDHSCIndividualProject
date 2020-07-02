using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonAnimated : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void ButtonDown()
    {
        animator.SetBool("ButtonDown", true); //animate button being pressed down
    }

    public void ButtonUp()
    {
        animator.SetBool("ButtonDown", false); //animate button being released
    }
}



