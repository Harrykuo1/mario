﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundBoard2 : MonoBehaviour {
    public float r;
    public float w;
    public float Speed;

    public float x;
    public float y;
    // Use this for initialization
    void Start()
    {
        r = 3;
        Speed = 1;
    }
    // Update is called once per frame
    void Update()
    {
        w += Speed * Time.deltaTime;
        x = Mathf.Cos(w + 3) * r + 76;
        y = Mathf.Sin(w + 3) * r + 9;
        transform.position = new Vector3(x, y, transform.position.z);
    }
}