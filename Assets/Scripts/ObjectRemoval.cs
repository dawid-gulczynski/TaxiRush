using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRemoval : MonoBehaviour
{
    public Transform playerTransform; 
    public float removalDistance = 400f; 

    private void LateUpdate()
    {
        Vector3 playerPosition = playerTransform.position;

        GameObject[] objectsInScene = GameObject.FindGameObjectsWithTag("Map");

        foreach (GameObject obj in objectsInScene)
        {
            if (obj.transform == playerTransform)
                continue;

            if (IsObjectBehindPlayer(obj.transform.position, playerPosition))
            {
                obj.SetActive(false);
            }
        }
    }

    private bool IsObjectBehindPlayer(Vector3 objectPosition, Vector3 playerPosition)
    {
        Vector3 playerToObject = objectPosition - playerPosition;

        if (Vector3.Dot(playerToObject, playerTransform.forward) < 0f)
        {
            if (playerToObject.magnitude > removalDistance)
            {
                return true;
            }
        }

        return false;
    }
}
