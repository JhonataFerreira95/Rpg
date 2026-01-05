using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{   
    [Header("Amounts")]
    [SerializeField] private int woodAmount;
    [SerializeField] private float timeAmount;
    [SerializeField] private Color starColor;
    [SerializeField] private Color endColor;

    [Header("Components")]
    [SerializeField] private SpriteRenderer houseSprite;
    [SerializeField] private Transform point;
    [SerializeField] private GameObject houseColl;

    private bool detectingPlayer;
    private Player player;
    private PlayerAnim playerAnim;
    private float timeCount;
    private bool isBegining;
    private PlayerItens playerItens;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
        playerAnim = player.GetComponent<PlayerAnim>();
        playerItens = player.GetComponent<PlayerItens>();
    }

    // Update is called once per frame
    void Update()
    {
        if(detectingPlayer && Input.GetKeyDown(KeyCode.E) && playerItens.totalWood >= woodAmount)
        {   
            //Construção é incializada
            isBegining = true;
            playerAnim.OnHammeringStart();
            houseSprite.color = starColor;
            player.transform.position = point.position;
            player.isPaused = true;
            playerItens.totalWood -= woodAmount;
        }
        if(isBegining)
        {
            timeCount += Time.deltaTime;
            if(timeCount >= timeAmount)
            {
                //casa é finalizda
                playerAnim.OnHammeringEnded();
                houseSprite.color = endColor;
                player.isPaused = false;
                houseColl.SetActive(true);
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
