using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CarNames : MonoBehaviour
{
    public TextMeshProUGUI carNames;
    public TextMeshProUGUI carPrices;

    private void Update()
    {
        carNames.text = GarageMan.Instance.carsInfo[CarSelection.currentCar].name.ToString();
        carPrices.text = GarageMan.Instance.carsInfo[CarSelection.currentCar].price.ToString();
    }
}
