using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maps : MonoBehaviour
{
    //private Action<GameObject> _killaction1;
    private Action<Maps> _killAction;
    private Vector3 playerPosition;
    private Vector3 removingDistance;

    public void Init(Action<Maps> killAction)
    {
        _killAction = killAction;
    }


    void FixedUpdate()
    {
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
        removingDistance = GameObject.FindGameObjectWithTag("Map").transform.position;

        if(removingDistance.z < playerPosition.z)
        {
            _killAction(this);
        }
    }
}
