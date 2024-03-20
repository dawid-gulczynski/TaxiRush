using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Colision : MonoBehaviour
{
    private float TwojaStara;

    //private void Update()
    //{
    //    foreach (GameObject ObstacleCars in GameObject.FindGameObjectsWithTag("Cars"))
    //    {
    //        foreach (GameObject ObstacleCars2 in GameObject.FindGameObjectsWithTag("Cars"))
    //        {
    //            TwojaStara = ObstacleCars.transform.position.z - ObstacleCars2.transform.position.z;

    //            if (TwojaStara > 5)
    //            {
    //                //ObstacleCars2.transform.position = new Vector3(ObstacleCars2.transform.position.x, ObstacleCars2.transform.position.y, ObstacleCars2.transform.position.z + 5);


    //                Debug.Log("Sta³o siê");
    //            }
    //            else
    //            {
    //                if (ObstacleCars2.activeSelf == false)
    //                {
    //                    ObstacleCars2.SetActive(true);
    //                }
    //            }
    //        }
    //    }
    //}

    private void OnCollisionStay(Collision collisionInfo)
    {
        Debug.Log("Dawid Peda³");
    }
}
