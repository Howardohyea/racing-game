using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class FullLapTrigger : MonoBehaviour
{
    public GameObject LapCompleteTrigger;
    public GameObject HalfLapTrigger;
    public GameObject LapNumberNumber;
    int LapCount = 0;
    public GameObject bestTime;


    void OnTriggerEnter()
    {
        // Turn off Lap Complete Trigger, and turn on Half Lap Trigger
        LapCompleteTrigger.SetActive(false);
        HalfLapTrigger.SetActive(true);

        // Increment LapCount
        LapCount++;
        LapNumberNumber.GetComponent<Text>().text = LapCount + " ";

        // best time number change the number
        if (TimerText.timelapsed < Int32.Parse(bestTime.GetComponent<Text>().text))
        { 
            bestTime.GetComponent<Text>().text = TimerText.timelapsed + "";
            TimerText.timelapsed = 0;
        }
        else
        {
            TimerText.timelapsed = 0;
        }

        
        //resets the thingie after full lap
        TimerText.timelapsed = 0;

    }
}
