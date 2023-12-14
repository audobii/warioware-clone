using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] GameObject spawnable;
    public float projVelocity = 700f;

    void Update()
    {
        if(Input.GetMouseButtonDown(0)) {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 2;

            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            GameObject proj = Instantiate(spawnable, mousePos, Quaternion.identity);
            //proj.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, projVelocity, 0));
        }
    }
}
