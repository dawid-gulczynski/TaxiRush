using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UIElements;
using System;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
    public float driveSpeed = GarageMan.Instance.carsInfo[CarSelection.currentCar].startSpeed;
    public float turnSpeed = 5f;

    public float maxTurnSpeed;
    private float maxCarSpeed = 500f;

    float l0 = 65f;
    float l1 = 58f;
    float l2 = 51.25f;
    float l3 = 44.5f;
    float l4 = 37.5f;

    bool lane0;
    bool lane1;
    bool lane2;
    bool lane3;
    bool lane4;

    private float endXPos = 0;

    private Vector3 fingerDown;
    private Vector3 fingerUp;
    private DateTime _fingerDownTime;
    private DateTime _fingerUpTime;
    public bool detectSwipeOnlyAfterRelease = false;


    public float swipeThresHold = 40f;
    public float timeThreshold = 0.3f;

    private float defaultY = 2.82f;

    private void Start()
    {
        this.transform.position = new Vector3(65f, 2.82f, -76.64f);
        lane0 = true;
        lane1 = false;
        lane2 = false;
        lane3 = false;
        lane4 = false;
    }
    private void Update()
    {

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

        if (transform.position.y < defaultY - 10f)
        {
            defaultY = transform.position.y;
            GameManager.inst.DistanceCounter();
        }



        transform.Translate(Vector3.forward * Time.deltaTime * driveSpeed, Space.World);


        if (transform.position.x == l0 || transform.position.x == l1 || transform.position.x == l2 || transform.position.x == l3 || transform.position.x == l4)
        {
            foreach (Touch touch in Input.touches)
            {
                if (touch.phase == TouchPhase.Began)
                {
                    fingerUp = touch.position;
                    fingerDown = touch.position;
                }

                //Detects Swipe while finger is still moving
                if (touch.phase == TouchPhase.Moved)
                {
                    if (!detectSwipeOnlyAfterRelease)
                    {
                        fingerDown = touch.position;
                        checkSwipe();
                    }
                }

                //Detects swipe after finger is released
                if (touch.phase == TouchPhase.Ended)
                {
                    fingerDown = touch.position;
                    checkSwipe();
                }
            }
        }

        //if (Input.touchCount > 0)
        //{
        //    Touch touch = Input.GetTouch(0);

        //    if (Time.timeScale != 0f)
        //    {
        //        if (touch.phase == TouchPhase.Began)
        //        {
        //            if (lane1 == true)
        //            {
        //                if (touch.position.x < Screen.width / 2 && transform.position.x > -7f)
        //                {
        //                    transform.DOMoveX(l2, 0.5f);
        //                    lane1 = false;
        //                    lane2 = true;
        //                }

        //                if (touch.position.x > Screen.width / 2 && transform.position.x > -7f)
        //                {
        //                    transform.DOMoveX(l0, 0.5f);
        //                    lane1 = false;
        //                    lane0 = true;
        //                }
        //            }
        //            else if (lane0 == true)
        //            {
        //                if (touch.position.x < Screen.width / 2 && transform.position.x > -7f)
        //                {
        //                    transform.DOMoveX(l1, 0.5f);
        //                    lane0 = false;
        //                    lane1 = true;
        //                }
        //            }
        //            else if (lane2 == true)
        //            {
        //                if (touch.position.x < Screen.width / 2 && transform.position.x > -7f)
        //                {
        //                    transform.DOMoveX(l3, 0.5f);
        //                    lane2 = false;
        //                    lane3 = true;
        //                }

        //                if (touch.position.x > Screen.width / 2 && transform.position.x > -7f)
        //                {
        //                    transform.DOMoveX(l1, 0.5f);
        //                    lane2 = false;
        //                    lane1 = true;
        //                }
        //            }
        //            else if (lane3 == true)
        //            {
        //                if (touch.position.x < Screen.width / 2 && transform.position.x > -7f)
        //                {
        //                    transform.DOMoveX(l4, 0.5f);
        //                    lane3 = false;
        //                    lane4 = true;
        //                }

        //                if (touch.position.x > Screen.width / 2 && transform.position.x > -7f)
        //                {
        //                    transform.DOMoveX(l2, 0.5f);
        //                    lane3 = false;
        //                    lane2 = true;
        //                }
        //            }
        //            else if (lane4 == true)
        //            {
        //                if (touch.position.x > Screen.width / 2 && transform.position.x > -7f)
        //                {
        //                    transform.DOMoveX(l3, 0.5f);
        //                    lane4 = false;
        //                    lane3 = true;
        //                }
        //            }
        //        }
        //    }
        //}
    }



    void checkSwipe()
    {
        //var duration = (float)_fingerUpTime.Subtract(_fingerDownTime).TotalSeconds;
        //var dirVector = fingerUp - fingerDown;

        //if (duration > timeThreshold) return;
        //if (dirVector.magnitude < swipeThresHold) return;
        //Check if Horizontal swipe
        if (horizontalValMove() > swipeThresHold)
        {
            //Debug.Log("Horizontal");
            if (fingerDown.x - fingerUp.x > 0)//Right swipe
            {
                if (lane1 == true)
                {
                    endXPos = Mathf.Clamp(endXPos, l2, l0); //l4 l0
                    transform.DOMoveX(l0, GarageMan.Instance.carsInfo[CarSelection.currentCar].turningSpeed);
                    lane1 = false;
                    lane0 = true;
                }
                else if (lane2 == true)
                {
                    endXPos = Mathf.Clamp(endXPos, l3, l1);//l4 l0
                    transform.DOMoveX(l1, GarageMan.Instance.carsInfo[CarSelection.currentCar].turningSpeed);
                    lane2 = false;
                    lane1 = true;

                }
                else if (lane3 == true)
                {
                    endXPos = Mathf.Clamp(endXPos, l4, l2);//l4 l0
                    transform.DOMoveX(l2, GarageMan.Instance.carsInfo[CarSelection.currentCar].turningSpeed);
                    lane3 = false;
                    lane2 = true;
                }
                else if (lane4 == true)
                {
                    endXPos = Mathf.Clamp(endXPos, l4, l3);//l4 l0
                    transform.DOMoveX(l3, GarageMan.Instance.carsInfo[CarSelection.currentCar].turningSpeed);
                    lane4 = false;
                    lane3 = true;
                }
            }
            else if (fingerDown.x - fingerUp.x < 0)//Left swipe
            {
                if (lane1 == true)
                {
                    endXPos = Mathf.Clamp(endXPos, l2, l0); //l4 l0
                    transform.DOMoveX(l2, GarageMan.Instance.carsInfo[CarSelection.currentCar].turningSpeed);
                    lane1 = false;
                    lane2 = true;
                }
                else if (lane0 == true)
                {
                    endXPos = Mathf.Clamp(endXPos, l1, l0); //l4 l0 
                    transform.DOMoveX(l1, GarageMan.Instance.carsInfo[CarSelection.currentCar].turningSpeed);
                    lane0 = false;
                    lane1 = true;
                }
                else if (lane2 == true)
                {
                    endXPos = Mathf.Clamp(endXPos, l3, l1); //l4 l0 
                    transform.DOMoveX(l3, GarageMan.Instance.carsInfo[CarSelection.currentCar].turningSpeed);
                    lane2 = false;
                    lane3 = true;
                }
                else if (lane3 == true)
                {
                    endXPos = Mathf.Clamp(endXPos, l4, l2); //l4 l0
                    transform.DOMoveX(l4, GarageMan.Instance.carsInfo[CarSelection.currentCar].turningSpeed);
                    lane3 = false;
                    lane4 = true;
                }
            }
            fingerUp = fingerDown;
        }
    }
    float horizontalValMove()
    {
        return Mathf.Abs(fingerDown.x - fingerUp.x);
    }
    //    if (touch.position.x<Screen.width / 2 && transform.position.x> -7f)
    //                {
    //                    transform.DOMoveX(transform.position.x - 7f, 1.5f);
    //                }

    //if (touch.position.x > Screen.width / 2 && transform.position.x > -7f)
    //{
    //    transform.DOMoveX(transform.position.x + 7f, 1.5f);
    //}
    //public float driveSpeed = 8f;
    //public float turnSpeed = 5f;

    //public float maxCarSpeed;
    //private Touch Touch;

    //private float touchSpeed = 0.01f;


    //private CharacterController cc;
    //private Vector3 direction;
    //public float forwardSpeed;

    //private int desireLane = 1;
    //public float laneDistance;

    //private void Start()
    //{
    //    cc = GetComponent<CharacterController>();
    //}

    //private void Update()
    //{
    //    direction.z = forwardSpeed;

    //    if (Input.touchCount > 0)
    //    {
    //        Touch = Input.GetTouch(0);

    //        if (Time.timeScale != 0f)
    //        {
    //            if (this.gameObject.transform.position.x < Borders.rightSide && this.gameObject.transform.position.x > Borders.leftSide)
    //            {
    //                if (Touch.phase == TouchPhase.Moved)
    //                {
    //                    if (Touch.deltaPosition.x > 0)
    //                    {
    //                        desireLane++;
    //                        if (desireLane == 3)
    //                            desireLane = 2;
    //                    }
    //                    if (Touch.deltaPosition.x < 0)
    //                    {
    //                        desireLane--;
    //                        if (desireLane == -1)
    //                            desireLane = 0;
    //                    }

    //                    Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;

    //                    if (desireLane == 0)
    //                    {
    //                        targetPosition += Vector3.left * laneDistance;
    //                    }
    //                    else if(desireLane == 2)
    //                    {
    //                        targetPosition += Vector3.right * laneDistance;
    //                    }

    //                    transform.position = targetPosition;


    //                }
    //            }
    //        }

    //    }
    //}

    //private void FixedUpdate()
    //{
    //    cc.Move(direction * Time.fixedDeltaTime);
    //}


    //void LateUpdate()
    //{
    //    if (driveSpeed < maxCarSpeed)
    //    {
    //        if (Time.timeScale != 0f)
    //        {
    //            driveSpeed = driveSpeed + 0.04f;
    //            turnSpeed = turnSpeed + 0.01f;
    //        }

    //    }

    //    transform.Translate(Vector3.forward * Time.deltaTime * driveSpeed, Space.World);

    //    if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
    //    {
    //        if (this.gameObject.transform.position.x >= Borders.leftSide)
    //        {
    //            transform.Translate(Vector3.left * Time.deltaTime * turnSpeed);

    //        }
    //    }

    //    if (Input.touchCount > 0)
    //    {
    //        Touch = Input.GetTouch(0);

    //        if (Time.timeScale != 0f)
    //        {
    //            if (this.gameObject.transform.position.x < Borders.rightSide && this.gameObject.transform.position.x > Borders.leftSide)
    //            {
    //                if (Touch.phase == TouchPhase.Moved)
    //                {
    //                    if (Touch.deltaPosition.x > 0)
    //                    {
    //                        transform.position = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
    //                    }
    //                    else if (Touch.deltaPosition.x < 0)
    //                    {
    //                        transform.position = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
    //                    }

    //                }
    //            }
    //        }

    //    }

    //    if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
    //    {
    //        if (this.gameObject.transform.position.x <= Borders.rightSide)
    //        {
    //            transform.Translate(Vector3.right * Time.deltaTime * turnSpeed);

    //        }
    //    }
    //}
}
