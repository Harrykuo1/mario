using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfterTurtoise : MonoBehaviour
{
    public int derecters = -1;
    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position += new Vector3(0.1f * derecters, 0, 0);

    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Turnright")
        {
            derecters *= -1;
            this.gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if (coll.gameObject.tag == "Turnleft")
        {
            derecters *= -1;
            this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
