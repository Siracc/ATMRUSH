using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeMovenment : MonoBehaviour
{
    public Transform _connectedMode;



    private void Update()
    {
        transform.position = new Vector3(

        Mathf.Lerp(transform.position.x, _connectedMode.position.x, Time.deltaTime * 5), 
         _connectedMode.position.y,
         _connectedMode.position.z +1);
    }

}
