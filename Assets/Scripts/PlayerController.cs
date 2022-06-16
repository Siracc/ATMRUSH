using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float _horSpeed, _verSpeed;
    float _sinirla;


    private void FixedUpdate()
    {
        PlayerMove();
    }


    void PlayerMove()
    {
        float _horizontal = Input.GetAxis("Horizontal");
        //float _vertical = Input.GetAxis("Vertical");

       // transform.position += new Vector3(_horizontal * _horSpeed * Time.deltaTime, 0, _vertical * _verSpeed * Time.deltaTime);
        transform.Translate(_horizontal * _horSpeed * Time.deltaTime, 0, _verSpeed  * Time.deltaTime);
        _sinirla = transform.position.x;
        _sinirla = Mathf.Clamp(_sinirla,-4, 4);
        transform.position = new Vector3(_sinirla, transform.position.y, transform.position.z);
    }
}
