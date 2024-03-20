using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float driveSpeed = 8f;
    public float turnSpeed = 5f;

    public float maxCarSpeed;
    private Touch Touch;

    private float touchSpeed = 0.01f;



    void LateUpdate()
    {
        if(driveSpeed < maxCarSpeed)
        {
            driveSpeed = driveSpeed + 0.04f;
            turnSpeed = turnSpeed + 0.01f;
        }

        transform.Translate(Vector3.forward * Time.deltaTime * driveSpeed, Space.World);

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            if (this.gameObject.transform.position.x > Borders.leftSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * turnSpeed);

            }
        }

        if(Input.touchCount > 0)
        {
            Touch = Input.GetTouch(0);

            if(this.gameObject.transform.position.x <= Borders.rightSide - 1 && this.gameObject.transform.position.x >= Borders.leftSide + 1)
            {
                if(Touch.phase == TouchPhase.Moved)
                {
                    transform.position = new Vector3(transform.position.x + Touch.deltaPosition.x * touchSpeed, transform.position.y, transform.position.z);
                }
            }
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            if (this.gameObject.transform.position.x < Borders.rightSide)
            {
                transform.Translate(Vector3.right * Time.deltaTime * turnSpeed);

            }
        }
    }
}
