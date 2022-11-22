using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private Jump JumpMod;

    [SerializeField]
    float timeLeft; 
    
    float Maxtime = 6.0f;
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            JumpMod.Jumping(); 
        }
        if (timeLeft <= 0)
        { 
            timeLeft = Maxtime;
        }
    }
}
