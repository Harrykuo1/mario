using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.gameObject.transform.position += new Vector3(-0.1f , -0.057f , 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "IsGrounded&CanDestroy")
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "Charactor")
        {
            GameObject.Find("Mario").GetComponent<Player3>().ReduceLifenow();
        }
    }
}
