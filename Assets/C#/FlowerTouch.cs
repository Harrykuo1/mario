using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerTouch : MonoBehaviour {
    private int Directerer = 1;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (gameObject.transform.position.y >= 1.2f)
        {
            Directerer = -1;
        }
        if (gameObject.transform.position.y <= -1.3f)
        {
            Directerer = 1;
        }
        gameObject.transform.position += new Vector3(0, 0.03f * Directerer, 0);
    }
}
