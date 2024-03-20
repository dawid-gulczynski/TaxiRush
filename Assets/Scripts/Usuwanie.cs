using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Usuwanie : MonoBehaviour
{
    public Vector3 pozycja;
    private GameObject[] objects;
    private void LateUpdate()
    {
        objects = GameObject.FindGameObjectsWithTag("Map");

        pozycja = GameObject.FindGameObjectWithTag("Niszczyciel").transform.position;
    }

    //private void OnTriggerEnter(Collider trigger)
    //{
    //    if(trigger.tag == "Player")
    //    {
    //        foreach (GameObject obj in objects)
    //        {
    //            if (obj.CompareTag("Map") && obj.transform.position.z < pozycja.z - 50)
    //            {
    //                obj.SetActive(false);
    //            }
    //        }
    //    }
    //}

    //private void OnTriggerEnter(Collider detector)
    //{
    //    GameObject.FindGameObjectWithTag("Map").SetActive(false);
    //}
}
