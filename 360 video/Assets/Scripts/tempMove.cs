using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tempMove : MonoBehaviour
{

    public float speed = 3;

    //This is just a test script to look around with the mouse.
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Debug.Log("click");
            transform.RotateAround(transform.position, -Vector3.up, speed * Input.GetAxis("Mouse X"));
            transform.RotateAround(transform.position, transform.right, speed * Input.GetAxis("Mouse Y"));
        }
    }
}
