using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceTriangle : MonoBehaviour {
    public int ctrl = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (ctrl == 1)
        {
            transform.position += new Vector3(0, -0.2f, 0);
        }
	}
    public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Charactor")
        {
            ctrl = 1;
        }
    }
    public void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "IsGrounded&CanDestroy")
        {
            Destroy(coll.gameObject);
        }
        if (coll.gameObject.tag == "Charactor")
        {
            GameObject.Find("Mario").GetComponent<Player2>().ReduceLifenow();
        }
    }
}
