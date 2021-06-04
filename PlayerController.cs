using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Transform player_tr;
    Rigidbody player_rb;
    float vert;
    float horiz;
    int time = 60;
    public Text timerText;

     void Timer()
    {
        time = time - 1;
        timerText.text = "Timer: " + time;
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Timer", 1f, 1f);
        player_tr = GetComponent<Transform>();
        player_rb = GetComponent<Rigidbody>();

       
    }

    // Update is called once per frame
    void Update()
    {
        horiz = Input.GetAxis("Horizontal") * 3f;
        vert = Input.GetAxis("Vertical") * 20f;
        player_rb.AddForce(player_tr.forward * vert);
        player_tr.Rotate(0,horiz,0);

    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="ax")
        {
            Destroy(gameObject);
        }
        
    }


    
}
