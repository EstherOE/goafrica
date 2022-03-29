﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatfromDestroyer : MonoBehaviour
{
    public GameObject platformDestructionPoint;
    // Start is called before the first frame update
    void Start()
    {
        platformDestructionPoint = GameObject.Find("PlatfromDestroyPoint");
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z< platformDestructionPoint.transform.position.z)
        {
            Destroy(gameObject);
        }
    }
}
