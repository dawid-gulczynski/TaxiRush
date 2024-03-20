using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void gameRestart()
    {
        GameManager.inst.score = 0;
        GameManager.inst.distance = 0;
        Looser.loosed = false;
        GameOver.ifEnded = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
