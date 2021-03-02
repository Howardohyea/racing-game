using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrackSelectMenu : MonoBehaviour
{
    bool bullshit

    public void PlayTrack1()
    {
        SceneManager.LoadScene(1);
        bullshit = true;

    }
    public void Update()
    {
        bullshit = false;
        //just make sure everything related to bullshit is removed during the final coding session
    }

    public void Quitgame()
    {
        Application.Quit();
    }
}
