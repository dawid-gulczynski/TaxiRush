using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AchieveCoins : MonoBehaviour
{
    public TextMeshProUGUI coinsRecordDisplay;

    public static int coinsAchieved;

    public GameObject coins1;
    public GameObject coins2;
    public GameObject coins3;
    public GameObject coins4;
    public GameObject coins5;

    private void Update()
    {
        coinsRecordDisplay.text = $"{coinsAchieved}/5";
    }
    public void Check()
    {
        if(CoinsMaxGained.coinsGainedRecord > 10)
        {
            coins1.SetActive(true);
            coinsAchieved++;
        }
        if (CoinsMaxGained.coinsGainedRecord > 50)
        {
            coins2.SetActive(true);
            coinsAchieved++;
        }
        if (CoinsMaxGained.coinsGainedRecord > 100)
        {
            coins3.SetActive(true);
            coinsAchieved++;
        }
        if (CoinsMaxGained.coinsGainedRecord > 500)
        {
            coins4.SetActive(true);
            coinsAchieved++;
        }
        if (CoinsMaxGained.coinsGainedRecord > 1000)
        {
            coins5.SetActive(true);
            coinsAchieved++;
        }
    }
}
