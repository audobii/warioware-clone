using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform activePlayer;
    private void Start()
    {
        transform.eulerAngles = new Vector3(transform.eulerAngles.x + 30, transform.eulerAngles.y, transform.eulerAngles.z);
    }

    void Update()
    {
        transform.position = activePlayer.position + new Vector3(0,2,-4);
    }
}
