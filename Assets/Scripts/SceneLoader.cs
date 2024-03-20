using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadScene(string gameName)
    {
        SceneManager.LoadScene(gameName);

    //#if UNITY_ANDROID
    //    ReviewPopup.Instance.Show();
    //#endif

    }
}
