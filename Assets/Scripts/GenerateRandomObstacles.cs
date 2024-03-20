using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateRandomObstacles : MonoBehaviour
{
    public GameObject[] przeszkoda;
    public float interval;
    private int zPosition;
    private int yPosition;

    private bool czyTak = false;
    public int przeszkodaNumber;
    IEnumerator SpawnObstacle()
    {
        przeszkodaNumber = Random.Range(1, 6);

        zPosition = Random.Range(-30, 13);

        Instantiate(przeszkoda[przeszkodaNumber], new Vector3(61, yPosition, zPosition), Quaternion.identity);
        zPosition += 50;

        yield return new WaitForSeconds(1.5f);
        czyTak = false;
    }

    void LateUpdate()
    {
        if(czyTak == false)
        {
            czyTak = true;
            StartCoroutine(SpawnObstacle());
        }
    }

}
