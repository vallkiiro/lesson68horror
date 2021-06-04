using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_controller : MonoBehaviour
{
    Transform cube_tr;
    Rigidbody cube_rb;
    float horiz;
    float vert;
   
    void Start()
    {
        cube_tr = GetComponent<Transform>();
        cube_rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        horiz = Input.GetAxis("Horizontal") *5f;
        vert = Input.GetAxis("Vertical");
        
        //cube_tr.Translate(0,0,vert*10f);
        cube_rb.AddForce(cube_tr.forward * vert * 20f);
        cube_tr.Rotate(0,horiz,0);
    }
}
