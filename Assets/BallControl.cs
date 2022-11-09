using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{

    Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        //rigid.velocity =new Vector3(2,10,-2);
        //rigid.AddForce(Vector3.up * 100, ForceMode.Impulse);

    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        if (Input.GetButton("Jump"))
        {
            rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);
        }
        //Debug.Log(rigid.velocity);
        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

        rigid.AddForce(vec, ForceMode.Impulse);

        
    }
}
