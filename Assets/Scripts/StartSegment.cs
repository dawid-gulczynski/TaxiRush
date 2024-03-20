using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSegment : MonoBehaviour
{

    public GameObject start;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(start, new Vector3(0, -40, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
