using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtoiseShell : MonoBehaviour {
    public int derecters = 1;
    public int count = 0;
    public int dir=0;
    public int ctrl = 0;
    public float speed = 0.2f;
    // Use this for initialization
    void Start()
    {

    }
    void Update()
    {
        this.gameObject.transform.position += new Vector3(speed * derecters, 0, 0);
        if (derecters == 1)
        {
            dir = 0;
        }
        else
        {
            dir = 180;
        }

    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Turnright")
        {
            derecters *= -1;
            this.gameObject.transform.rotation = Quaternion.Euler(0, dir, 0);
        }
        if (coll.gameObject.tag == "Turnleft"&&count==1)
        {
            derecters *= -1;
            this.gameObject.transform.rotation = Quaternion.Euler(0, dir, 0);
            count = 1;
        }
        if (coll.gameObject.tag == "IsGrounded&CanDestroy")
        {

            if (ctrl == 0)
            {
                derecters *= -1;
                ctrl++;
                speed -= 0.01f;
            }
            else if (ctrl == 1)
            {
                ctrl = 0;
            }
            this.gameObject.transform.rotation = Quaternion.Euler(0, dir, 0);
            Destroy(coll.gameObject);
        }
    }
}
