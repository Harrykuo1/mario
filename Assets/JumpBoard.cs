using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoard : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Charactor")
        {
            this.gameObject.transform.localScale = new Vector3(0.8f, 0.5f, 0);
        }
    }
    private void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Charactor")
        {
            this.gameObject.transform.localScale = new Vector3(0.8f, 0.8f, 0);
        }
    }
}
