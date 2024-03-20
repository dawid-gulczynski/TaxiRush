using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarageCarMove : MonoBehaviour
{ 
    private Touch Touch;

    private float touchSpeed = 0.5f;

    private void LateUpdate()
    {

        if (Input.touchCount > 0)
        {
            Touch = Input.GetTouch(0);

            if (Touch.phase == TouchPhase.Moved)
            {
                transform.Rotate(0f, Touch.deltaPosition.y * touchSpeed, 0f);
            }


        }
    }

}
