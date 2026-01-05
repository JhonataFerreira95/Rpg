using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{   
    [SerializeField] private Sprite houseSprite;
    [SerializeField] private Color starColor;
    [SerializeField] private Color endColor;
    [SerializeField] private float timeAmount;

    private bool detectingPlayer;
    private PlayerItens player;
    private float timeCount;
    private bool isBegining;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerItens>();
    }

    // Update is called once per frame
    void Update()
    {
        if(detectingPlayer && Input.GetKeyDown(KeyCode.E))
        {
            isBegining = true;

        }
        if(isBegining)
        {
            timeCount += Time.deltaTime;
            if(timeCount >= timeAmount)
            {
                //casa é finalizda
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            detectingPlayer = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            detectingPlayer = false;
        }
    }
}
