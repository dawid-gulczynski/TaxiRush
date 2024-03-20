using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public int rotate = 1;

    void Update()
    {
        transform.Rotate(0, rotate, 0, Space.World);
    }
}
