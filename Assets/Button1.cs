using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Charactor")
        {
            this.gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
            GameObject.Find("LeftStone").SendMessage("Openw");
            GameObject.Find("RightStone").SendMessage("Opens");
        }
    }
}
