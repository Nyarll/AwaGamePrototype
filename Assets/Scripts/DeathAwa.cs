﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathAwa : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject obj = collision.gameObject;
        if(obj.tag == "Player")
        {
            //Destroy(obj);
            obj.SetActive(false);
        }
    }
}
