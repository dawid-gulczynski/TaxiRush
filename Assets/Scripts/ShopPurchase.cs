using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopPurchase : MonoBehaviour
{
    private ISaveGameProgres gameProgres = new SaveGameProgres();
    private SaveFileObject data = new SaveFileObject();
    public bool coins;
    public int amount;

    public void Purchase()
    {
        if(coins == true)
        {
            Wallet.coinsWallet += amount;
        }
        else
        {
            DiamondsWallet.diamondsWallet += amount;
        }

        gameProgres.SaveData();
    }
}
