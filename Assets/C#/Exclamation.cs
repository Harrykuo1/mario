using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exclamation : MonoBehaviour {
    public GameObject AfterExclamation;
    public GameObject Shiitake;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Charactor")
        {
            Destroy(this.gameObject);
            Vector3 pos = this.gameObject.transform.position;
            Instantiate(AfterExclamation, pos, gameObject.transform.rotation);
            Vector3 poss = this.gameObject.transform.position+=new Vector3(0,1,0);
            Instantiate(Shiitake, poss, gameObject.transform.rotation);
        }
    }
}
