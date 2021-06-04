using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie_Controller : MonoBehaviour
{
    float vert;
    Rigidbody zombie_rb;
    Transform zombie_tr;
    // Start is called before the first frame update
    void Start()
    {
        zombie_tr = GetComponent<Transform>();
        zombie_rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {      
        vert = Input.GetAxis("Vertical") * 15f;
        zombie_rb.AddForce(zombie_tr.forward * vert);
    }
}
