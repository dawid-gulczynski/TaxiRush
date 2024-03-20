using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    private Transform position;
    public GameObject gate;
    public GameObject coins;
    private int lane, lane2;
    private bool spawn = true;

    private float zPos, zPos2;
    private Vector3 pos, pos2;
    private float distance, distance2;

    float[] location = { 32.48f, 39.62f, 46.1f, 52.8f, 59.7f };
    
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            if(spawn == true)
            {
                distance = Random.Range(230, 400);
                distance2 = Random.Range(230, 400);
                zPos = gate.transform.position.z + distance;
                zPos2 = gate.transform.position.z + distance2;

                lane = Random.Range(0, location.Length);
                lane2 = Random.Range(0, location.Length);
                pos = new Vector3(location[lane], 0.85f, zPos);
                if(lane != lane2)
                {
                    pos2 = new Vector3(location[lane2], 0.85f, zPos2);
                    Instantiate(coins, pos2, Quaternion.Euler(0, 0, 0));
                }

                Instantiate(coins, pos, Quaternion.Euler(0, 0, 0));
            }
        }

        
    }

}