using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimIFRN : MonoBehaviour
{
    private PlayerIFRN player;
    private Animator anim;

    private int lastIdle = 3;

    void Start()
    {
        player = GetComponent<PlayerIFRN>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        Vector2 dir = player.direction;
        bool isMoving = dir.sqrMagnitude > 0;

        int value;

        if (isMoving)
        {
            int walkValue = GetWalkValue(dir);
            lastIdle = GetIdleFromWalk(walkValue);
            value = walkValue;
        }
        else
        {
            value = lastIdle;
        }

        anim.SetInteger("Transition", value);
    }

    private int GetWalkValue(Vector2 dir)
    {
        if (Mathf.Abs(dir.x) > Mathf.Abs(dir.y))
            return dir.x > 0 ? 6 : 5; 
        else
            return dir.y > 0 ? 4 : 7; 
    }

    private int GetIdleFromWalk(int walkValue)
    {
        switch (walkValue)
        {
            case 4: return 2; 
            case 5: return 1; 
            case 6: return 0; 
            case 7: return 3; 
            default: return 3;
        }
    }
}