using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Looser : MonoBehaviour
{

    public GameObject car;
    public ISaveGameProgres _gameProgres = new SaveGameProgres();
    public static bool loosed = false;
    private void OnTriggerEnter(Collider other)
    {

        if (loosed == false)
        {
            if (other.CompareTag("Player"))
            {
                GameOver.ifEnded = true;
                Wallet.EarnCoins();
                Best.BestCheck();
                AchieveGamesPlayed.GamesPlayed++;
                CoinsMaxGained.CoinsRecordChecker();
                _gameProgres.SaveData();
                loosed = true;
            }
        }

    }
}
