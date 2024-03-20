using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public GameObject soundON;
    public GameObject soundOFF;
    public AudioSource sound;

    public void OnClick()
    {
        sound.Play();
    }

    public void OptionsClick()
    {
        if(soundON.activeSelf == true)
        {
            sound.volume = 0f;
            soundON.SetActive(false);
            soundOFF.SetActive(true);
        }
        else
        {
            sound.volume = 1f;
            soundOFF.SetActive(false);
            soundON.SetActive(true);
        }
    }
}
