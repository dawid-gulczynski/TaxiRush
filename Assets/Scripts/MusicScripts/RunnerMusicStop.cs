using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RunnerMusicStop : MonoBehaviour
{
    private void Update()
    {
        if(SceneManager.GetActiveScene().name == "Runner")
        {
            DontStopTheMusic.instance.GetComponent<AudioSource>().Pause();
            //RunnerMusic.instance.GetComponent<AudioSource>().mute = false;
        }
        
        if(SceneManager.GetActiveScene().name != "Runner")
        {
            DontStopTheMusic.instance.GetComponent<AudioSource>().UnPause();
        }
    }

    public void RestartMusic()
    {
        RunnerMusic.instance.GetComponent<AudioSource>().Play();
    }

    public void RunnerMute()
    {
        RunnerMusic.instance.GetComponent<AudioSource>().Stop();
    }

}
