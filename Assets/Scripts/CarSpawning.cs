using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class CarSpawning : MonoBehaviour
{
    public GameObject gate;
    public GameObject[] prefab;
    private int lane, lane2, lane3;
    private int prefabNumb, prefabNumb2, prefabNumb3;
    private bool spawn = true;
    private float distance, distance2;

    private Vector3 actual;

    private Vector3 pos, pos2, pos3;
    private float zPos;
    //private bool start = true;

    float[] location = { 65f, 58f, 44.5f, 37.5f };

    //private void Start()
    //{
    //    if(start == true)
    //    {
    //        lane = Random.Range(0, location.Length);
    //        lane2 = Random.Range(0, location.Length);
    //        lane3 = Random.Range(0, location.Length);
    //        distance = Random.Range(200, 390);
    //        distance2 = Random.Range(300, 650);
    //        distance3 = Random.Range(200, 300);

    //        distance = 80 + distance;
    //        distance2 = 80 + distance2;
    //        distance3 = 80 + distance3;

    //        pos = new Vector3(location[lane], 2.8f, distance);
    //        pos2 = new Vector3(location[lane2], 2.8f, distance2);
    //        pos3 = new Vector3(location[lane3], 2.8f, distance3);

    //        prefabNumb = Random.Range(0, prefab.Length);
    //        prefabNumb2 = Random.Range(0, prefab.Length);
    //        prefabNumb3 = Random.Range(0, prefab.Length);

    //        prefab[prefabNumb].SetActive(true);
    //        prefab[prefabNumb2].SetActive(true);
    //        prefab[prefabNumb3].SetActive(true);

    //        Instantiate(prefab[prefabNumb], pos, Quaternion.Euler(0, 180, 0));
    //        Instantiate(prefab[prefabNumb2], pos2, Quaternion.Euler(0, 180, 0));
    //        Instantiate(prefab[prefabNumb3], pos3, Quaternion.Euler(0, 180, 0));

    //        start = false;
    //    }
    //}

    void OnTriggerEnter(Collider player)
    {
        zPos = gate.transform.position.z + 400f;

        if (player.CompareTag("Player"))
        {
            if (spawn == true)
            {
                //lane = Random.Range(0, location.Length);
                //lane2 = Random.Range(0, location.Length);
                //lane3 = Random.Range(0, location.Length);

                //distance = Random.Range(300, 450);
                //distance2 = Random.Range(300, 650);

                //if(distance == distance2)
                //{
                //    distance2 = Random.Range(300, 600);
                //}

                //distance = gate.transform.position.z + distance;
                //distance2 = gate.transform.position.z + distance2;

                //pos = new Vector3(location[lane], 2.8f, zPos);
                //pos2 = new Vector3(location[lane2], 2.8f, distance);
                //pos3 = new Vector3(location[lane3], 2.8f, distance2);

                //actual = GameObject.FindGameObjectWithTag("Cars").transform.position;


                lane = Random.Range(0, location.Length);
                lane2 = Random.Range(0, location.Length);
                lane3 = Random.Range(0, location.Length);

                distance = Random.Range(gate.transform.position.z + 300, gate.transform.position.z + 450);
                distance2 = Random.Range(gate.transform.position.z + 300, gate.transform.position.z + 650);

                if (distance == distance2)
                {
                    distance2 = Random.Range(300, 600);
                }

                distance = gate.transform.position.z + distance;
                distance2 = gate.transform.position.z + distance2;

                pos = new Vector3(location[lane], 2.8f, zPos);
                pos2 = new Vector3(location[lane2], 2.8f, distance);
                pos3 = new Vector3(location[lane3], 2.8f, distance2);


                prefabNumb = Random.Range(0, prefab.Length);
                prefabNumb2 = Random.Range(0, prefab.Length);
                prefabNumb3 = Random.Range(0, prefab.Length);
                prefab[prefabNumb].SetActive(true);
                prefab[prefabNumb2].SetActive(true);
                prefab[prefabNumb3].SetActive(true);
                var car = Instantiate(prefab[prefabNumb], pos, Quaternion.Euler(0, 180, 0));
                var car2 = Instantiate(prefab[prefabNumb2], pos2, Quaternion.Euler(0, 180, 0));
                var car3 = Instantiate(prefab[prefabNumb3], pos3, Quaternion.Euler(0, 180, 0));
                car.gameObject.tag = "Cars";
                car2.gameObject.tag = "Cars";
                car3.gameObject.tag = "Cars";

                spawn = false;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        spawn = true;
    }

    //private void Spawning()
    //{
    //    lane = Random.Range(0, location.Length);
    //    lane2 = Random.Range(0, location.Length);
    //    lane3 = Random.Range(0, location.Length);

    //    distance = Random.Range(gate.transform.position.z + 300, gate.transform.position.z + 450);
    //    distance2 = Random.Range(gate.transform.position.z + 300,gate.transform.position.z + 650);

    //    if (distance == distance2)
    //    {
    //        distance2 = Random.Range(300, 600);
    //    }

    //    distance = gate.transform.position.z + distance;
    //    distance2 = gate.transform.position.z + distance2;

    //    pos = new Vector3(location[lane], 2.8f, zPos);
    //    pos2 = new Vector3(location[lane2], 2.8f, distance);
    //    pos3 = new Vector3(location[lane3], 2.8f, distance2);

    //}
}
