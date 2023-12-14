using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDControl : MonoBehaviour
{
    void Update()
    {
        //directions dont match up - "W"/forward is left, etc.

        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.left * Time.deltaTime*2);
        } else if(Input.GetKey(KeyCode.S)) 
        {
            transform.Translate(Vector3.right * Time.deltaTime*2); 
        } else if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.forward * Time.deltaTime*2);
        } else if(Input.GetKey(KeyCode.A)) 
        {
            transform.Translate(Vector3.back * Time.deltaTime*2);
        }

        transform.Translate(Vector3.down * Time.deltaTime);
    }
}
