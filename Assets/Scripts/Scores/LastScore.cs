using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LastScore : MonoBehaviour
{
    public TextMeshProUGUI lastScoreDisplay;

    private void Update()
    {
        lastScoreDisplay.text = $"{GameManager.inst.distance}";
    }
}
