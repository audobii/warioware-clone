using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MelonTrigger : MonoBehaviour
{
    [SerializeField] GameObject watermelon;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("PlayerMelon"))
        {
            //Debug.Log("make suika");
            Instantiate(watermelon, transform.position, Quaternion.identity);
            Destroy(other.gameObject);
            Destroy(gameObject.transform.parent.gameObject);
        }
    }
}
