using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItens : MonoBehaviour
{

    public int totalWood;
    public float currentWater;

    private float waterLimit = 55;
    public void WaterLimit(float Water)
    {   
       if(currentWater < waterLimit)
        {
          currentWater += Water;  
        }
    }
}
