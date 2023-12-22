using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RotatingObject : MonoBehaviour//, IBeginDragHandler, IDragHandler
{
    [SerializeField] GameObject objectToRotate;
    float speed = 5.0f;

    /*
    public void OnBeginDrag(PointerEventData eventData)
    {

    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("dragging");
        float horizontal = speed * eventData.delta.x * Mathf.Deg2Rad;
        float vertical = speed * eventData.delta.y * Mathf.Deg2Rad;

        objectToRotate.transform.Rotate(Vector3.up, -horizontal);
        objectToRotate.transform.Rotate(Vector3.right, vertical);
        
    }
    */
    private void Update()
    {
        if(Input.GetMouseButton(0)) {
            Debug.Log("holding LMB");
            float horizontal = speed * Input.GetAxis("Mouse X");
            float vertical = speed * Input.GetAxis("Mouse Y");

            objectToRotate.transform.Rotate(Vector3.up, -horizontal);
            objectToRotate.transform.Rotate(Vector3.right, vertical);
        }


    }
}
