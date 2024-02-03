using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move3 : MonoBehaviour {
    int directer = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.gameObject.transform.position += new Vector3(0,0.1f * directer, 0);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "turndown")
        {
            directer = -1;
        }
        if (collision.gameObject.tag == "turnup")
        {
            directer = 1;
        }
    }
}
