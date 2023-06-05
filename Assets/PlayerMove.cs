using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float gravity = 20f;

    [SerializeField] private bool up = false;
    
    
    Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            up = !up;
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb2d.AddForce(-transform.right * 5);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            rb2d.AddForce(transform.right * 5);
        }

        if (up == true)
        {
            rb2d.AddForce(transform.up * gravity);
        }

        if (up == false)
        {
            rb2d.AddForce(-transform.up * gravity);
        }
    }
}
