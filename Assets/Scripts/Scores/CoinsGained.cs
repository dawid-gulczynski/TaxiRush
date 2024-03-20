using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinsGained : MonoBehaviour
{
    public TextMeshProUGUI coinsGainedDisplay;

    private void Update()
    {
        coinsGainedDisplay.text = $"{GameManager.inst.score + (GameManager.inst.distance/2)}";
    }
}
