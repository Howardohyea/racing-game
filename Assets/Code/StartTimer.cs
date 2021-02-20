using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartTimer : MonoBehaviour
{
    public GameObject timerText;
    public bool isTakingTime = false;
    public int timeLeft = 3;

    public GameObject AI;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isTakingTime == false)
        {
            StartCoroutine(SubtractSecond());
        }
    }
    IEnumerator SubtractSecond()
    {
        isTakingTime = true;
        timerText.GetComponent<Text>().text = timeLeft + "";
        timeLeft = timeLeft - 1;
        if (timeLeft == -1)
        {
            AI.SetActive(true);
            isTakingTime = true;
            timerText.SetActive(false);
        }
        yield return new WaitForSeconds(1);
        if (timeLeft != -1)
        {
            isTakingTime = false;
        }
    }
}
