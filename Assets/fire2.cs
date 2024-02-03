using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire2 : MonoBehaviour {
    float k;
    // Use this for initialization
    IEnumerator routines()
    {
        yield return new WaitForSeconds(1.65f);
        Destroy(this.gameObject);
    }
    void Start () {
		float p=GameObject.Find("Mario").transform.rotation.y;
        
        if (p == 0)
        {
            k = 1;
        }
        else
        {
            k = -1;
        }
        StartCoroutine(routines());
    }
    
    // Update is called once per frame
    void Update () {
        this.gameObject.transform.position += new Vector3(0.1f*k, 0, 0);
    }
}
