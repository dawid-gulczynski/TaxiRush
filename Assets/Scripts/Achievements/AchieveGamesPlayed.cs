using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class AchieveGamesPlayed : MonoBehaviour
{
    public static int gamesPlayedAchiev = 0;
    public TextMeshProUGUI display;
    public GameObject games10;
    public GameObject games20;
    public GameObject games30;
    public GameObject games50;
    public GameObject games100;
    public static int GamesPlayed = 0;

    private void Update()
    {
        display.text = $"{gamesPlayedAchiev}/5";
    }

    public void Check()
    {
        if (GamesPlayed >= 10)
        {
            games10.SetActive(true);
            gamesPlayedAchiev++;
        }
        if (GamesPlayed >= 20)
        {
            games20.SetActive(true);
            gamesPlayedAchiev++;
        }
        if (GamesPlayed >= 30)
        {
            games30.SetActive(true);
            gamesPlayedAchiev++;
        }
        if (GamesPlayed >= 50)
        {
            games50.SetActive(true);
            gamesPlayedAchiev++;
        }
        if (GamesPlayed >= 100)
        {
            games100.SetActive(true);
            gamesPlayedAchiev++;
        }
    }
}
