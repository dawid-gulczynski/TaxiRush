using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsPopUp : MonoBehaviour
{
    public void OptionsActivator()
    {
        Update();
    }
    public static bool pauseActive = false;
    public GameObject OptionsUI;

    void Update()
    {
        if (pauseActive)
        {
            Active();
        }
        else
        {
            InActive();
        }
    }
    public void Active()
    {
        Time.timeScale = 0f;
        OptionsUI.SetActive(true);
        pauseActive = true;
    }
    public void InActive()
    {
        OptionsUI.SetActive(false);
        pauseActive = false;
        Time.timeScale = 0f;
    }
}
