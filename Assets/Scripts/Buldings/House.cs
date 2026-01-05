using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{   
    [SerializeField] private GameObject houseColl;
    [SerializeField] private Transform point;
    [SerializeField] private SpriteRenderer houseSprite;
    [SerializeField] private Color starColor;
    [SerializeField] private Color endColor;
    [SerializeField] private float timeAmount;

    private bool detectingPlayer;
    private Player player;
    private PlayerAnim playerAnim;
    private float timeCount;
    private bool isBegining;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
        playerAnim = player.GetComponent<PlayerAnim>();
    }

    // Update is called once per frame
    void Update()
    {
        if(detectingPlayer && Input.GetKeyDown(KeyCode.E))
        {
            isBegining = true;
            playerAnim.OnHammeringStart();
            houseSprite.color = starColor;
            player.transform.position = point.position;
            player.isPaused = true;
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
