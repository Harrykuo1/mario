﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firedelete : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "FireToChar")
        {
            Destroy(collision.gameObject);
        }
    }
}
