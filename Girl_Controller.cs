using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Girl_Controller : MonoBehaviour
{
    Transform girl_tr;
    AudioSource crying;
    // Start is called before the first frame update
    void Start()
    {
        girl_tr = GetComponent<Transform>();
        crying = GetComponent<AudioSource>();
        crying.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="player")
        {
           print("ты меня спас");
        }
    }

     void OnMouseDown()
    {
         print("Осторожно, там убийца...");
        crying.Stop();
    }
}
