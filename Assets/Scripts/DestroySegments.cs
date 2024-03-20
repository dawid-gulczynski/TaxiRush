using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using System;


public class DestroySegments : MonoBehaviour
{
    RandomizeSegments randomize;
    public Vector3 position;
    private Vector3 playerPosition;
    private Vector3 distanceMapRemoving;

    private void LateUpdate()
    {
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
        try
        {
            position = GameObject.FindGameObjectWithTag("Cars").transform.position;
        }
        catch (Exception )
        {

        }
        distanceMapRemoving = GameObject.FindGameObjectWithTag("Map").transform.position;

        playerPosition = new Vector3(playerPosition.x, playerPosition.y, playerPosition.z - 100);

        if (position.z < playerPosition.z)
        {
            if(GameObject.FindGameObjectWithTag("Cars") == true)
            {
                GameObject.FindGameObjectWithTag("Cars").SetActive(false);
            }
        }

        MapDelete();
    }

    public void MapDelete()
    {
        if (distanceMapRemoving.z < playerPosition.z)
        {
            GameObject.FindGameObjectWithTag("Map").SetActive(false);
        }
    }
}
