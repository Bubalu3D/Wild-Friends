using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungerThirstUI : MonoBehaviour
{
    [SerializeField] private HungerThirstManager hungerThirstManager;

    [SerializeField] private Image hungerMeter, thirstMeter;

    public GameObject food;
    public GameObject addFoodUI;
    public GameObject water;
    public GameObject addWaterUI;

    private void FixedUpdate()
    {
        hungerMeter.fillAmount = hungerThirstManager.hungerPercent;
        thirstMeter.fillAmount = hungerThirstManager.thirstPercent;
    }

    private void Update()
    {
        if (food.activeSelf == false)
        {
            addFoodUI.SetActive(true);
        }
        else
        {
            addFoodUI.SetActive(false);
        }


        if (water.activeSelf == false)
        {
            addWaterUI.SetActive(true);
        }
        else
        {
            addWaterUI.SetActive(false);
        }
    }
}
