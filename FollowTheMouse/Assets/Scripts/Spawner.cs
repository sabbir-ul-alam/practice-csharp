﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    GameObject teddyBear;

   // TeddyBear teddy;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("ShowUpTeddy") > 0)
        {
            print("spawner called");
            Instantiate(teddyBear, transform.position, Quaternion.identity);
            
          
        }

    }
}
