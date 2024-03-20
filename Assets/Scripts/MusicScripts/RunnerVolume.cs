using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerVolume : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (DontStopTheMusic.instance.GetComponent<AudioSource>().volume == 0)
        {
            RunnerMusic.instance.GetComponent<AudioSource>().volume = 0;
        }
        else
        {
            RunnerMusic.instance.GetComponent<AudioSource>().volume = 100;
        }
    }
}
