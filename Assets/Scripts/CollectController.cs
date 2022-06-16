using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectController : MonoBehaviour
{



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Money"))
        {
            other.gameObject.transform.position = transform.position + Vector3.forward;
            Destroy(gameObject.GetComponent<CollectController>());
            other.gameObject.AddComponent<CollectController>();
            other.gameObject.GetComponent<BoxCollider>().isTrigger = false;
            other.gameObject.AddComponent<ModeMovenment>();
            other.gameObject.GetComponent<ModeMovenment>()._connectedMode = transform;
            other.gameObject.tag = "Collected";
        }
    }
}
