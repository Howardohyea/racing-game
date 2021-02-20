using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TimerText : MonoBehaviour
{
    public GameObject timerText;
    bool isAddingTime = false;
    public static double timelapsed = 0;


    // Update is called once per frame
    void Update()
    {
        if (isAddingTime == false)
        {
            StartCoroutine(SubtractSecond());
        }
    }
    IEnumerator SubtractSecond()
    {
        isAddingTime = true;
        timerText.GetComponent<Text>().text = timelapsed + "";
        timelapsed = Math.Round(timelapsed + 0.105,2);
        yield return new WaitForSeconds(0.1f);
        isAddingTime = false;
    }
}
