using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeSegments : MonoBehaviour
{

    public GameObject[] section;
    public bool spawningSegment = false;
    public int zPosiotion = 500;
    public int yPosition = -40;
    public float spawningSpeed = 1f;
    public bool delete = false;

    public int sceneNumber;

    void Update()
    {
        if (spawningSpeed >= 1.2)
        {
            spawningSpeed = spawningSpeed - 0.0005f;
        }

        if (spawningSegment == false)
        {
            spawningSegment = true;
            StartCoroutine(SectionOfGenerate());
        }

    }

    public IEnumerator SectionOfGenerate()
    {
        sceneNumber = Random.Range(0, 5);
        section[sceneNumber].SetActive(true);
        section[sceneNumber].gameObject.tag = "Map";
        Instantiate(section[sceneNumber], new Vector3(0, yPosition, zPosiotion), Quaternion.identity);
        zPosiotion += 150;
        yield return new WaitForSeconds(spawningSpeed);
        spawningSegment = false;
    }
}
