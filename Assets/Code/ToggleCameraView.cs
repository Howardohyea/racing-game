using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleCameraView : MonoBehaviour
{
    public GameObject HoodCam;
    public GameObject MainCamInside;
    bool HoodCamOn = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("tab"))
        {
            if (HoodCamOn)
            {
                HoodCam.SetActive(false);
                MainCamInside.SetActive(true);
                HoodCamOn = false;
                return;
            }
            if (!HoodCamOn)
            {
                HoodCam.SetActive(true);
                MainCamInside.SetActive(false);
                HoodCamOn = true;
            }
        }
    }
}
