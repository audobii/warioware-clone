using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //testing gamecontroller for win/lose handling of just watermelon lvl

    public GameObject timer;
    public GameObject WLH;
    bool completed = false;

    void Update()
    {
        if(!completed)
        {
            if(timer.GetComponent<Timer>().currTime <= 0.0f)
            {
                WLH.GetComponent<WinLoseHandler>().fail();
                completed = true;
            }
        }
    }
}
