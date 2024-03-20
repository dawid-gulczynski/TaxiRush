using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skręciikD : MonoBehaviour
{

    [SerializeField] WheelCollider frontLeft;
    [SerializeField] WheelCollider frontRight;
    [SerializeField] WheelCollider backLeft;
    [SerializeField] WheelCollider backRight;

    private float turningRadius;
    public float maxAngle = 15f;

    private float currentAngle = 0f;

    private void FixedUpdate()
    {
        currentAngle = maxAngle * Input.GetAxis("Horizontal");
        frontLeft.steerAngle = currentAngle;
        frontRight.steerAngle = currentAngle;
    }
}
