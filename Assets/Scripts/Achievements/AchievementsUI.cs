using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementsUI : MonoBehaviour
{
    public GameObject achievementsPanel;

    public void Show()
    {
        achievementsPanel.SetActive(true);
    }

    public void Hide()
    {
        achievementsPanel.SetActive(false);
        AchieveGamesPlayed.gamesPlayedAchiev = 0;
        AchieveScoreReached.scoreAchieved = 0;
        AchieveCarsPurchased.cars = 0;
        AchieveCarsPurchased.carsAchieved = 0;
        AchieveCoins.coinsAchieved = 0;
    }
}
