using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{

    [Header("Items")]
    [SerializeField] private Image WaterUIBar;
    [SerializeField] private Image WoodUIBar;
    [SerializeField] private Image CarrotUIBar;

    [Header("Tools")]
    // [SerializeField] private Image AxeUI;
    // [SerializeField] private Image ShovelUI;
    // [SerializeField] private Image BucketUI;
    [SerializeField] private Color selectColor;
    [SerializeField] private Color alphaColor;
    public List<Image> toolsUI = new List<Image>();

    private PlayerItens playerItens;
    private Player player;

    private void Awake()
    {
        playerItens = FindAnyObjectByType<PlayerItens>();
        player = playerItens.GetComponent<Player>();
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

        //toolsUI[player.handlingObj].color = selectColor;

        for (int i = 0; i < toolsUI.Count; i++)
        {
            if(i == player.handlingObj)
            {
                toolsUI[i].color = selectColor;
            }
            else
            {
                toolsUI[i].color = alphaColor;  
            }
        }
    }
}
