using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerAnim : MonoBehaviour
{

    private Player player;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Player>();
        anim = GetComponent<Animator>();
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
}
