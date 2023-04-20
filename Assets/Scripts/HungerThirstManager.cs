using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HungerThirstManager : MonoBehaviour
{
    [Header("Hunger")]

    [SerializeField] private float maxHunger;
    [SerializeField] private float hungerDepletionRate = 1f;
    public float currentHunger;
    public float hungerPercent => currentHunger / maxHunger;


    [Header("Thirst")]

    [SerializeField] private float maxThirst;
    [SerializeField] private float thirstDepletionRate = 1f;
    public float currentThirst;
    public float thirstPercent => currentThirst / maxThirst;

    private void Start()
    {
        currentHunger = Random.Range(10,40);
        currentThirst = Random.Range(5,30);

    }

    private void Update()
    {
        currentHunger -= hungerDepletionRate * Time.deltaTime;
        currentThirst -= thirstDepletionRate * Time.deltaTime;

        if(currentHunger <=0 || currentThirst <= 0 )
        {
            currentHunger = 0;
            currentThirst = 0;
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            ReplenishHunger();
            print("H pressed");
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            ReplenishThirst();
            print("T pressed");
        }
    }



    public void ReplenishHunger()
    {
        currentHunger += 60;

        if (currentHunger > maxHunger)
        { currentHunger = maxHunger;}

     

    }

    public void ReplenishThirst()
    {
     
        currentThirst += 60;

        if (currentThirst > maxThirst)
        { currentThirst = maxThirst; }

    }







}


