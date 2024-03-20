using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Wallet : MonoBehaviour
{
    public static int coinsWallet = 100;

    public TextMeshProUGUI coinsDisplay;

    public static void EarnCoins()
    {
        coinsWallet = coinsWallet + GameManager.inst.score + (GameManager.inst.distance/2);
    }

    private void Update()
    {
        coinsDisplay.text = "" + coinsWallet;
    }
}
