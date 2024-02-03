using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall1 : MonoBehaviour {
    Rigidbody2D rig2ds;
    // Use this for initialization
    void Start () {
        rig2ds = GetComponent<Rigidbody2D>();
        rig2ds.AddForce(new Vector2(0, 950f));
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
