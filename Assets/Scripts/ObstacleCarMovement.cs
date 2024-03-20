using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCarMovement : MonoBehaviour
{
    public float driveSpeed = 8f;


    private void LateUpdate()
    {
        transform.Translate(Vector3.back * Time.deltaTime * driveSpeed, Space.World);

    }
}
