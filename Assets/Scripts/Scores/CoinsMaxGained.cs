using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsMaxGained : MonoBehaviour
{
    public static int coinsGainedRecord = 0;

    public static void CoinsRecordChecker()
    {
        if(GameManager.inst.score + (GameManager.inst.distance/2) > coinsGainedRecord)
        {
            coinsGainedRecord = GameManager.inst.score + (GameManager.inst.distance / 2);
        }
    }
}
