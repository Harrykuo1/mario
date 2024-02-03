using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class board4 : MonoBehaviour
{
    public int xmove = 1;
    public int ymove = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += new Vector3(0.05f * xmove, 0, 0);
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Turnright")
        {
            xmove = 1;
        }
        if (col.tag == "Turnleft")
        {
            xmove = -1;
        }
    }
}
