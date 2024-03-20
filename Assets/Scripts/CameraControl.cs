using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float driveSpeed = 8f;
    public float turnSpeed = 5f;

    public float maxTurnSpeed;
    public float maxCarSpeed;

    public Vector3 distance;
    public float lookUp;
    public float lerpAmount;
    private float rotationX = 30f;

    public GameObject carObject;
    public GameObject cameraObject;

    void Start()
    {
        cameraObject = GameObject.FindGameObjectWithTag("MainCamera");
        QualitySettings.vSyncCount = 1;
        Application.targetFrameRate = 60;

        carObject = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, carObject.transform.position + distance, lerpAmount * Time.deltaTime);
        cameraObject.transform.rotation = Quaternion.Euler(new Vector3(rotationX, 0, 0));

        //transform.LookAt(carObject.transform.position);
        transform.Rotate(-lookUp, 0, 0);

        if (driveSpeed < maxCarSpeed)
        {
            if (Time.timeScale != 0f)
            {
                driveSpeed = driveSpeed + 0.04f;
                if (turnSpeed < maxTurnSpeed)
                {
                    turnSpeed = turnSpeed + 0.01f;
                }
            }
        }

    }
}
