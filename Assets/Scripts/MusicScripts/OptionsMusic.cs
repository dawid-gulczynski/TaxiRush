using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMusic : MonoBehaviour
{
    public GameObject musicON;
    public GameObject musicOFF;


    public void ChangeActive()
    {
        if(musicON.activeSelf == true)
        {
            DontStopTheMusic.instance.GetComponent<AudioSource>().volume = 0;
            musicOFF.SetActive(true);
            musicON.SetActive(false);
        }
        else if(musicON.activeSelf == false)
        {
            DontStopTheMusic.instance.GetComponent <AudioSource>().volume = 100;
            musicOFF.SetActive(false);
            musicON.SetActive(true);
        }
    }

    public void Checker()
    {
        if(DontStopTheMusic.instance.GetComponent<AudioSource>().volume != 0)
        {
            musicON.SetActive(true); musicOFF.SetActive(false);
        }
        else
        {
            musicON.SetActive(false);
            musicOFF.SetActive(true);
        }
    }
}
