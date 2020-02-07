using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;

    float jumpSpeed = 2.0f;
    bool jumpState = false;

    float time = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jumpSpeed *= 150.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(0.1f, 0, 0));
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-0.1f, 0, 0));
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(!jumpState)
            {
                jumpState = true;
                rb.AddForce(transform.up * jumpSpeed);
            }
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (jumpState)
        {
            jumpState = false;
        }
    }
}
