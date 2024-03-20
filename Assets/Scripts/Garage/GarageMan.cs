using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarageMan : MonoBehaviour
{
    public static GarageMan Instance;

    public CarsInfo[] carsInfo;


    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
