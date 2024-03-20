using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CarBuy : MonoBehaviour
{
    private ISaveGameProgres gameProgres= new SaveGameProgres();
    private SaveFileObject data = new SaveFileObject();
    public GameObject selectButton;
    public GameObject buyButton;
    public GameObject notEnoughMoney;

    public GameObject coinsCar;
    public GameObject diamondsCar;



    

    private void Start()
    {

    }
    void Update()
    {
        
        foreach(GameObject car in CarSelection.carList)
        {
            if (GarageMan.Instance.carsInfo[CarSelection.currentCar].owned == true)
            {
                selectButton.SetActive(true);
                buyButton.SetActive(false);
            }
            else
            {
                selectButton.SetActive(false); buyButton.SetActive(true);
                if (GarageMan.Instance.carsInfo[CarSelection.currentCar].diamonds == true)
                {
                    coinsCar.SetActive(false);
                    diamondsCar.SetActive(true);
                }
                else
                {
                    coinsCar.SetActive(true);
                    diamondsCar.SetActive(false);
                }
            }
        }
    }
    public void tryBuy()
    {
        if (GarageMan.Instance.carsInfo[CarSelection.currentCar].diamonds == true)
        {
            if(DiamondsWallet.diamondsWallet >= GarageMan.Instance.carsInfo[CarSelection.currentCar].price)
            {
                GarageMan.Instance.carsInfo[CarSelection.currentCar].owned = true;
                DiamondsWallet.diamondsWallet -= GarageMan.Instance.carsInfo[CarSelection.currentCar].price;
                selectButton.SetActive(true);
                buyButton.SetActive(false);
                gameProgres.SaveData();
            }
            else
            {
                notEnoughMoney.SetActive(true);
            }
        }
        else
        {
            if (Wallet.coinsWallet >= GarageMan.Instance.carsInfo[CarSelection.currentCar].price)
            {
                GarageMan.Instance.carsInfo[CarSelection.currentCar].owned = true;
                Wallet.coinsWallet -= GarageMan.Instance.carsInfo[CarSelection.currentCar].price;
                selectButton.SetActive(true);
                buyButton.SetActive(false);
                gameProgres.SaveData();
            }
            else
            {
                notEnoughMoney.SetActive(true);
            }
        }

    }

    public void notEnoughHider()
    {
        notEnoughMoney.SetActive(false);
    }
}
