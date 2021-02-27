using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrackSelectMenu : MonoBehaviour
{

    public void PlayTrack1()
    {
        SceneManager.LoadScene(1);

    }

    public void Quitgame()
    {
        Application.Quit();
    }
}
