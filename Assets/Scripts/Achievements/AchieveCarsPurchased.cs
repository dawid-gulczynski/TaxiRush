using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AchieveCarsPurchased : MonoBehaviour
{
    public TextMeshProUGUI carsDisplay;
    public static int cars;
    public static int carsAchieved = 0;

    public GameObject cars5;
    public GameObject cars7;
    public GameObject carsALL;

    private void Update()
    {
        carsDisplay.text = $"{carsAchieved}/3";
    }

    public void Check()
    {
        for(int i = 0; i < GarageMan.Instance.carsInfo.Length; i++)
        {
            if (GarageMan.Instance.carsInfo[i].owned == true)
            {
                cars++;
            }
        }

        if(cars >= 5)
        {
            cars5.SetActive(true);
            carsAchieved++;
        }
        if(cars >= 7)
        {
            cars7.SetActive(true);
            carsAchieved++;
        }
        if(cars >= 12)
        {
            carsALL.SetActive(true);
            carsAchieved++;
        }
    }
}
