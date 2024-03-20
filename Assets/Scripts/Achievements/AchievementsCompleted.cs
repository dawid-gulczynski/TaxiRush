using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AchievementsCompleted : MonoBehaviour
{
    public TextMeshProUGUI achievementDisplay;
    public static int AchievementsDone = 0;

    // Update is called once per frame
    void Update()
    {
        AchievementsDone = AchieveGamesPlayed.gamesPlayedAchiev + AchieveScoreReached.scoreAchieved + AchieveCarsPurchased.carsAchieved + AchieveCoins.coinsAchieved;
        achievementDisplay.text = $"{AchievementsDone}/18";
    }
}
