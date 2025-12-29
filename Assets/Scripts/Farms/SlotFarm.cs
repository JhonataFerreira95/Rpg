using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotFarm : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite hole;
    [SerializeField] private Sprite carrot;

    [Header("Settings")]
    [SerializeField] private int digAmount; // Quantidade de escavação
    [SerializeField] private float waterAmount; // Total de água para nascer uma cenoura
    [SerializeField] private bool detecting;

    private int initialDigAmount;
    private float currentWater;
    private bool dugHole;

    private void Start()
    {
        initialDigAmount = digAmount;
    }

    private void Update()
    {
        if (dugHole)
        {
            if (detecting)
            {
                currentWater += 0.01f;
            }
            
            if(currentWater >= waterAmount)
            {
                spriteRenderer.sprite = carrot;
            }
        }
    }

    public void OnHit()
    {
        digAmount--;

        if(digAmount <= initialDigAmount / 2)
        {
            spriteRenderer.sprite = hole;
            dugHole = true;
        }

        //if(digAmount <= 0)
        //{
            //plantar cenoura
            //spriteRenderer.sprite = carrot;
        //}
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      if(collision.CompareTag("Dig"))
        {
            OnHit();
        }

        if (collision.CompareTag("Water"))
        {
            detecting = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Water"))
        {
            detecting = false;
        }
    }
}
