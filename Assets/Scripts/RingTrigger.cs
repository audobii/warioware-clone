using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class RingTrigger : MonoBehaviour
{
    //can generalize this script to any trigger objects that change sprite when collided w/
    [SerializeField] Sprite otherSprite;

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("passed thru ring");
        transform.GetComponent<SpriteRenderer>().sprite = otherSprite;
    }
}
