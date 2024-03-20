using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class AchieveScoreReached : MonoBehaviour
{
    public static int scoreAchieved;
    public TextMeshProUGUI scoreCount;
    public GameObject score100;
    public GameObject score500;
    public GameObject score1000;
    public GameObject score2000;
    public GameObject score5000;

    private void Update()
    {
        scoreCount.text = $"{scoreAchieved}/5";
    }

    public void Check()
    {
        if(Best.playersBest >= 100)
        {
            score100.SetActive(true);
            scoreAchieved++;
        }
        if (Best.playersBest >= 500)
        {
            score500.SetActive(true);
            scoreAchieved++;
        }
        if (Best.playersBest >= 1000)
        {
            score1000.SetActive(true);
            scoreAchieved++;
        }
        if (Best.playersBest >= 2000)
        {
            score2000.SetActive(true);
            scoreAchieved++;
        }
        if (Best.playersBest >= 5000)
        {
            score5000.SetActive(true);
            scoreAchieved++;
        }
    }
}
