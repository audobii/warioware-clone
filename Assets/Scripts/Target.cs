using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] Sprite bwTarget;

    //for testing hovering
    /*
    private void OnMouseOver()
    {
        transform.GetComponent<SpriteRenderer>().color = Color.red;
    }

    private void OnMouseExit()
    {
        transform.GetComponent<SpriteRenderer>().color = Color.white;
    }
    */

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("Bullet(Clone)")) { 
            transform.GetComponent<SpriteRenderer>().sprite = bwTarget;
            Destroy(other);
        }
    }
}
