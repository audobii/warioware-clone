using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] GameObject spawnable;

    void Update()
    {
        if(Input.GetMouseButtonDown(0)) {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 2;

            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            Instantiate(spawnable, mousePos, Quaternion.identity); 
        }
    }
}
