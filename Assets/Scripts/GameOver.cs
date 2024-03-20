using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public static bool ifEnded = false;
    public GameObject gameOverUI;
    //public GameObject gameUI;

    // Update is called once per frame
    void Update()
    {
        if (ifEnded)
            Ended();
        else
            Hide();
    }

    void Ended()
    {
        gameOverUI.SetActive(true);
        //gameUI.SetActive(false);
        Time.timeScale = 0f;
        ifEnded = true;
    }

    public void Hide()
    {
        Time.timeScale = 0f;
        gameOverUI.SetActive(false);
        //gameUI.SetActive(true);
        ifEnded = false;
        Looser.loosed = false;
    }
}
