using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Best : MonoBehaviour
{
    public static int playersBest = 0;

    public TextMeshProUGUI coinsDisplay;

    public static void BestCheck()
    {
        if(GameManager.inst.distance > playersBest)
        {
            playersBest = GameManager.inst.distance;
        }
    }

    private void Update()
    {
        coinsDisplay.text = $"{playersBest}" ;
    }
}
