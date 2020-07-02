using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    public Text timerText;
    private float startTime;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {

        float t = Time.time - startTime; //in case the startTime is different to the Time.time

        string minutes = ((int)t / 60).ToString(); //gives the integer part for the minutes
        string seconds = (t % 60).ToString("f2"); //gives the remainder for the seconds

        timerText.text = minutes + ":" + seconds; // displays minute:time
    }

}
