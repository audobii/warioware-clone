using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLoseHandler : MonoBehaviour
{
    //script for handling winning or losing a minigame
    //TODO: figure out if each level needs its own separate gamecontroller script? to handle win/lose conditions of specific lvl

    public void success()
    {
        Debug.Log("yay u did it! (success)");
    }

    public void fail()
    {
        Debug.Log("oof L (fail)");
    }
}
