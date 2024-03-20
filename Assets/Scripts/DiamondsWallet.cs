using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DiamondsWallet : MonoBehaviour
{
    public static int diamondsWallet = 0;

    public TextMeshProUGUI diamondsDisplay;

    private void Update()
    {
        diamondsDisplay.text = "" + diamondsWallet;
    }
}
