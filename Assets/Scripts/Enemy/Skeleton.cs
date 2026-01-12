using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Skeleton : MonoBehaviour
{

    [Header("Stats")]
    public float radius;
    public float totalHealth;
    public float currentHealth;
    public Image healthBar;
    public bool isDead;

    [Header("Components")]
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private AnimationControl animControl;

    private Player player;
    private bool detectPlayer;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = totalHealth;
        player = FindObjectOfType<Player>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!isDead && detectPlayer)
        {
            agent.SetDestination(player.transform.position);

            if(Vector2.Distance(transform.position, player.transform.position) <= agent.stoppingDistance)
            {
                //Chegou próximo do player, skeleton idle
                animControl.PlayAnim(2);
            }
            else 
            {
                //skeleton walking
                animControl.PlayAnim(1);
            }

            float posX = player.transform.position.x - transform.position.x;

            if(posX > 0)
            {
                transform.eulerAngles = new Vector2(0,0);
            }
            else
            {
                transform.eulerAngles = new Vector2(0,180);
            } 
        }
    }

    public void DetectPlayer()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, radius, player.gameObject.layer);

        if(hit != null)
        {
            // viu o player
            detectPlayer = true;
        }
        else
        {
            // n viu o player
            detectPlayer = false;
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
