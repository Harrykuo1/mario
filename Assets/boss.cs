using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class boss : MonoBehaviour
{
    int blood = 5;
    public GameObject Bullets;
    public GameObject castle;
    private Transform me;
    float jumpHeight = 620f;
    bool isGrounded = true;
    Rigidbody2D rig2d;
    bool ctrl = false;
    float Timer_f = 0f;
    int Timer_i = 0;
    int q = -1;
    // Use this for initialization
    void Start()
    {
        rig2d = GetComponent<Rigidbody2D>();
        me = GameObject.Find("boss").transform;
    }

    // Update is called once per frame
    IEnumerator routiness()
    {
        yield return new WaitForSeconds(2f);
    }
    void Update()
    {
        this.gameObject.transform.position += new Vector3(-0.05f*q,0, 0);
        if (ctrl)
        {
            rig2d.AddForce(new Vector2(0, jumpHeight));
            ctrl = false;
        }

        Timer_f += Time.deltaTime;
        Timer_i = (int)Timer_f;
        if (Timer_i == 1)
        {
            Vector3 posss = new Vector3(me.transform.position.x + 0.9f, me.transform.position.y - 1.4f, 0);
            Quaternion poa = new Quaternion(0, 0, 120, 70);
            Instantiate(Bullets, posss, poa);
            Timer_f = 0f;
        }
        if (blood == 0)
        {
            Destroy(this.gameObject);
            Vector3 posss = new Vector3(59f,10.4f, 0);
            Instantiate(castle, posss, Quaternion.identity);
        }
        if (me.position.x > 59.8)
        {
            q = 1;
        }
        if (me.position.x < 57.2)
        {
            q = -1;
        }
    }
       
    private void OnCollisionEnter2D(Collision2D col)
     {
            if (col.gameObject.tag == "IsGrounded&CanDestroy")
            {
                ctrl = true;
            }
        if (col.gameObject.tag == "myfire")
        {
            blood--;
            Destroy(col.gameObject);
        }
    }
 
}








/*using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
public class boss : MonoBehaviour
{
    int blood = 10;
    Rigidbody2D rig2d;
    float jumpHeight = 720f;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rig2d.AddForce(new Vector2(0, jumpHeight));
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "IsGrounded")
        {
            
            rig2d.AddForce(new Vector2(0, jumpHeight));
        }
    }
}
*/
