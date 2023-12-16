using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
        //hacky/temporary? way to get correct angle

        if (mousePos.x > 5) mousePos.x = 15; //left side
        else if (mousePos.x < -5) mousePos.x = -15; //right side
        else if (mousePos.x > 0) mousePos.x = 5; // left-mid
        else mousePos.x = -8; //right-mid

        if(mousePos.y < 0) mousePos.y = -5;

        transform.Translate(-1*(mousePos) * Time.deltaTime);

        //Debug.Log(mousePos);

        //aiming towards target?
        //transform.Translate((new Vector3(-3.26999998f, 1.3522892f, 5.48000002f)) * Time.deltaTime);

    }
}
