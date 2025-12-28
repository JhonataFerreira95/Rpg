using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotFarm : MonoBehaviour
{

    [SerializeField] private Sprite hole;
    [SerializeField] private Sprite carrot;
    [SerializeField] private int digAmount; // Quantidade de escavação

    public void OnHit()
    {
        digAmount--;

        if(digAmount <= 0)
        {
            //plantar cenoura
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      if(collision.CompareTag("Axe"))
        {
            OnHit();
        }  
    }
}
