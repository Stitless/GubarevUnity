﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GaiMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
        transform.Rotate(10.0f, 0.0f, 0.0f, Space.World);
    }
}
