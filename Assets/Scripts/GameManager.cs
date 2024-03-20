using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    public int distance;
    public static GameManager inst;
    

    public TMPro.TextMeshProUGUI scoreText;
    public TMPro.TextMeshProUGUI distanceText;

    public void IncrementCoins()
    {
        score++;
        scoreText.text = $"{score}";
    }

    public void DistanceCounter()
    {
        distance++;
        distanceText.text = $"{distance}";
    }

    private void Awake()
    {
        
        inst = this;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
