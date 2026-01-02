using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{

    [Header("Items")]
    [SerializeField] private Image WaterUIBar;
    [SerializeField] private Image WoodUIBar;
    [SerializeField] private Image CarrotUIBar;

    [Header("Tools")]
    [SerializeField] private Image AxeUI;
    [SerializeField] private Image ShovelUI;
    [SerializeField] private Image BucketUI;

    private PlayerItens playerItens;

    private void Awake()
    {
        playerItens = FindAnyObjectByType<PlayerItens>();
    }

    // Start is called before the first frame update
    void Start()
    {
        WaterUIBar.fillAmount = 0f;
        WoodUIBar.fillAmount = 0f;
        CarrotUIBar.fillAmount = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        WaterUIBar.fillAmount = playerItens.currentWater / playerItens.waterLimit;
        WoodUIBar.fillAmount = playerItens.totalWood / playerItens.woodLimit;
        CarrotUIBar.fillAmount = playerItens.carrots / playerItens.carrotLimit;
    }
}
