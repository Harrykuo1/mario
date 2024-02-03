using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterReturn : MonoBehaviour {

    public int directer;
	// Use this for initialization
	void Start () {
        directer = -1;
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.position += new Vector3(0.05f * directer, 0,0);
	}
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "turnback")
        {
            directer *= -1;
        }
    }
}
