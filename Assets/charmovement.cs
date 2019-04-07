using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charmovement : MonoBehaviour
{
    Rigidbody2D rb;
    Rigidbody2D vel;
    float timefloat = 0f;
    int timeint = 0;
    int ready = 0;

    // Use this for initialization
    void Start()
    {
        transform.position = new Vector3 (-0.031f, -4.115f, 0); 
        rb = GetComponent<Rigidbody2D>();
        vel = rb;
    }

    // Update is called once per frame
    void Update()
    {
        timefloat += Time.deltaTime;
        timeint = (int)timefloat;
        Debug.Log(timeint);
        if (timefloat >= 4f)
        {
            timefloat -= 5f;
        }
        if (timeint == 2)
        {
            ready = 1;
        }
        else
        {
            ready = 0;
        }
        vel.velocity = rb.velocity;
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = Vector2.left * 10;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = Vector2.right * 10;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = Vector2.up * 10;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = Vector2.down * 10;
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            rb.velocity = Vector2.left * 0;
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            rb.velocity = Vector2.right * 0;
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            rb.velocity = Vector2.up * 0;
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            rb.velocity = Vector2.down * 0;
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && ready == 2)
        {
            rb.velocity = vel.velocity * 20;
            Debug.Log("SPRINT!!");

        }
    }
}