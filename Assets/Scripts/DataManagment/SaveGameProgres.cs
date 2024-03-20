using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SaveGameProgres : ISaveGameProgres
{
    public IDataService dataService = new jsonDataService();
    private SaveFileObject data = new SaveFileObject();
    int ID;


    public void SaveData()
    {
        data.carUnlocked = GarageMan.Instance.carsInfo.Where(p => p.owned == true).Select(p => p.id).ToList();
        data.playerBest = Best.playersBest;
        data.playerCoins = Wallet.coinsWallet;
        data.playerDiamonds = DiamondsWallet.diamondsWallet;
        data.playerAchievements = AchievementsCompleted.AchievementsDone;
        data.playerGames = AchieveGamesPlayed.GamesPlayed;
        data.coinsRecord = CoinsMaxGained.coinsGainedRecord;
        dataService.SaveData<SaveFileObject>("/player-stats", data, true);
    }
}

