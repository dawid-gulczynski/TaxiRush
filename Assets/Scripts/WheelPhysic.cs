using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelPhysic : MonoBehaviour
{
    public WheelCollider wheelPhysic;
    private Vector3 wheelPosition = new Vector3();
    private Quaternion wheelRotation = new Quaternion();


    void LateUpdate()
    {
        wheelPhysic.GetWorldPose(out wheelPosition, out wheelRotation);
        transform.position = wheelPosition;
        transform.rotation = wheelRotation;
    }
}
