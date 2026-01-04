using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItens : MonoBehaviour
{

    [Header("Amounts")]
    public int totalWood;
    public int carrots;
    public float currentWater;
    public int fishes;

    [Header("Limits")]
    public float waterLimit = 50f;
    public float woodLimit = 5f;
    public float carrotLimit = 10f;
    public float fishesLimit = 5f;

    public void WaterLimit(float Water)
    {   
       if(currentWater < waterLimit)
        {
          currentWater += Water;  
        }
    }
}
