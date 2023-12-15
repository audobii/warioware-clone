using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADControl : MonoBehaviour
{
    void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 2);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * 2);
        }

        transform.Translate(Vector3.forward * Time.deltaTime*2);
    }
}
