using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting.FullSerializer;

public class CarSelection : MonoBehaviour
{
    [Header("Buttons and Canvas")]
    public Button nextButton;
    public Button previousButton;

    public static int currentCar;
    public static GameObject[] carList;
    public static int carListCount;

    private void Awake()
    {
        chooseCar(0);
    }

    private void Start()
    {
        currentCar = PlayerPrefs.GetInt("CarSelected");
        carList = new GameObject[transform.childCount];
        
        for(int i = 0; i < transform.childCount; i++)
        {
            carList[i] = transform.GetChild(i).gameObject;
            carListCount++;
        }

        foreach(GameObject car in carList)
        {
            car.SetActive(false);
        }

        if (carList[currentCar])
        {
            carList[currentCar].SetActive(true);
        }

        if (currentCar != 0)
        {
            previousButton.interactable = true;
        }

        if(currentCar == transform.childCount - 1)
        {
            nextButton.interactable = false;
        }
    }
    private void chooseCar(int index)
    {
        previousButton.interactable = (currentCar != 0);
        nextButton.interactable = (currentCar != transform.childCount - 1);
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(i == index);
        }
    }

    public void switchCar(int switchCars)
    {
        currentCar += switchCars;
        chooseCar(currentCar);
    }

    public void SelectCar()
    {
        PlayerPrefs.SetInt("CarSelected", currentCar);
        
    }
}
