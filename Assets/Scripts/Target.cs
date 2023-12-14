using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private void OnMouseOver()
    {
        transform.GetComponent<SpriteRenderer>().color = Color.red;
    }

    private void OnMouseExit()
    {
        transform.GetComponent<SpriteRenderer>().color = Color.white;
    }
}
