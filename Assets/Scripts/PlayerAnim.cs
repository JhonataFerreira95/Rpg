using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerAnim : MonoBehaviour
{

    private Player player;
    private Animator anim;
    private Casting cast;
    private bool isHitting;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Player>();
        anim = GetComponent<Animator>();
        cast = FindObjectOfType<Casting>();
    }

    // Update is called once per frame
    void Update()
    {
      OnMov(); 
      OnRun();
    }

    #region Movement

        void OnMov()
        {
            if(player.direction.sqrMagnitude > 0)
            {
                if (player.isRolling)
                {
                    anim.SetTrigger("isRoll");
                }
                else
                {
                    anim.SetInteger("transition", 1);
                }
            }
            else
            {
                anim.SetInteger("transition", 0);
            }

            if(player.direction.x > 0)
            {
                transform.eulerAngles = new Vector2(0, 0);
            }

            if(player.direction.x < 0)
            {
                transform.eulerAngles = new Vector2(0, 180);
            }

            if (player.isCutting)
            {
               anim.SetInteger("transition", 3);
            }

            if (player.isDigging)
            {
               anim.SetInteger("transition", 4);
            }

            if (player.isWatering)
            {
               anim.SetInteger("transition", 5);
            }
        }

        void OnRun()
        {
        if (player.isRunning)
        {
            anim.SetInteger("transition", 2);
        }
        }

    #endregion

    // Esse método é chamado quando o jogador pressiona o botão "E" no lago
    public void OnCastingStarted()
    {
        anim.SetTrigger("isCasting");
        player.isPaused = true;
    }

    // Esse método é chamado quando termina a animação de pescaria
    public void OnCastingEnded()
    {
        cast.OnCasting();
        player.isPaused = false;
    }

    public void OnHammeringStart()
    {
        anim.SetBool("hammering", true);
    }

    public void OnHammeringEnded()
    {
        anim.SetBool("hammering", false);
    }

    public void OnHit()
    {
        if(!isHitting)
        {
            anim.SetTrigger("hit");
            isHitting = true;
        }
    }
}
