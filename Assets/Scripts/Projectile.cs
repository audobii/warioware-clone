using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private void Start()
    {

    }

    void Update()
    {
        Vector3 mousePos = Input.mousePosition;

        mousePos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, Camera.main.transform.position.z));
        //change mousePos x based on where you are shooting from?

        transform.Translate(-1*(mousePos+Vector3.forward) * Time.deltaTime);
        Debug.Log(mousePos);
    }
}
