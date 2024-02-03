using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeRotaton : MonoBehaviour {
    public static PipeRotaton a;
	// Use this for initialization
	void Start () {
        a = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Rotation()
    {
        while (gameObject.transform.rotation.z > -45) {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, -2f);
        }
    }
}
