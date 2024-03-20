using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Borders : MonoBehaviour
{
    public static float rightSide = 66f;
    public static float leftSide = 36.5f;
    private GameObject player;

    private Vector3 borderLeft;
    private Vector3 borderRight;
    private Vector3 playerPos;
    private float inLeft;
    private float inRight;

    void FixedUpdate()
    {
        //player = GameObject.FindGameObjectWithTag("Player");
        //playerPos = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
        //borderLeft = new Vector3(leftSide + 0.3f, player.transform.position.y, player.transform.position.z);
        //borderRight = new Vector3(rightSide - 0.3f, player.transform.position.y, player.transform.position.z);

        //if(playerPos.x > borderRight.x)
        //{
        //    playerPos = new Vector3(65.8f, player.transform.position.y, player.transform.position.z);
        //}
        //else if(playerPos.x < borderLeft.x)
        //{
        //    playerPos = new Vector3(36.8f, player.transform.position.y, player.transform.position.z);
        //}

        inRight = rightSide;
        inLeft = leftSide;
    }
}
