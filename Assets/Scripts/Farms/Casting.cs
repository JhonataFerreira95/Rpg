using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Casting : MonoBehaviour
{
    [SerializeField] private int percentage; // porcentagem de chance de pescar um peixe

    private PlayerItens player;
    private PlayerAnim playerAnim;
    private bool detectingPlayer;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerItens>();
        playerAnim = player.GetComponent<PlayerAnim>();
    }

    // Update is called once per frame
    void Update()
    {
        if(detectingPlayer && Input.GetKeyDown(KeyCode.E))
        {
            playerAnim.OnCastingStarted();
        }
    }

    public void OnCasting()
    {
        int randomValue = Random.Range(1,100);

        if(randomValue <= percentage)
        {
            //conseguiu pescar um peixe
            Debug.Log("pescou");
        }
        else
        {
            //falhou
            Debug.Log("n pescou");
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
