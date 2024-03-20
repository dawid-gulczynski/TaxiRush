using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerMusic : MonoBehaviour
{
    public static RunnerMusic instance;
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

    }
}
