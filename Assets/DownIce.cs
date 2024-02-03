using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownIce : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Charactor")
        {
            transform.position += new Vector3(0,-0.15f,0);
        }
    }
}
