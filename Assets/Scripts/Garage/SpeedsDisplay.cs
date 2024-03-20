using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpeedsDisplay : MonoBehaviour
{
    public TextMeshProUGUI startSpeed;
    public TextMeshProUGUI VMax;

    private void Update()
    {
        startSpeed.text = GarageMan.Instance.carsInfo[CarSelection.currentCar].startSpeed.ToString();
        if(GarageMan.Instance.carsInfo[CarSelection.currentCar].turningSpeed > 0.4f)
        {
            VMax.text = "Slow";
        }else if(GarageMan.Instance.carsInfo[CarSelection.currentCar].turningSpeed <= 0.4f && GarageMan.Instance.carsInfo[CarSelection.currentCar].turningSpeed > 0.3f)
        {
            VMax.text = "Middling";
        }
        else if(GarageMan.Instance.carsInfo[CarSelection.currentCar].turningSpeed >= 0.3f)
        {
            VMax.text = "Fast";
        }
    }
}
