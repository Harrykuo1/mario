using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightClips : MonoBehaviour {
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Opens()
    {
        this.gameObject.transform.position = new Vector3(-3.142f, 4.56f, 1);
    }
}
