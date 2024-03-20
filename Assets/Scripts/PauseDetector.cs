using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PauseDetector : MonoBehaviour
{
    public void ClickDetector()
    {
        Update();
    }
    public static bool GameIsPaused = false;

    public GameObject pauseGameUI;

    void Update()
    {
       
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();

            }
    }

    public void Resume()
    {
        pauseGameUI.SetActive(false);
        Time.timeScale = 1.0f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        pauseGameUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }


}
