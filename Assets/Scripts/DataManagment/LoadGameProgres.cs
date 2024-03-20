using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LoadGameProgres : MonoBehaviour
{
    public IDataService dataService = new jsonDataService();

    public void Start()
    {
        LoadData();
    }
    public void LoadData()
    {
        var data = dataService.LoadData<SaveFileObject>("/player-stats", true);
        
            foreach (var item in data.carUnlocked)
            {
                GarageMan.Instance.carsInfo[item].owned = true;
            }

        Best.playersBest = data.playerBest;
        Wallet.coinsWallet = data.playerCoins;
        DiamondsWallet.diamondsWallet = data.playerDiamonds;
        AchievementsCompleted.AchievementsDone = data.playerAchievements;
        AchieveGamesPlayed.GamesPlayed = data.playerGames;
        CoinsMaxGained.coinsGainedRecord = data.coinsRecord;
    }
}
