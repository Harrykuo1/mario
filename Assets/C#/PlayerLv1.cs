using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class PlayerLv1 : MonoBehaviour
{
    private Transform camera;
    float jumpHeight = 720f;
    bool isGrounded = true;
    Rigidbody2D rig2d;
    public int lifenow = 0;
    int star = 0;
    int ctrl=0;
    // Use this for initialization
    void Start()
    {
        rig2d = GetComponent<Rigidbody2D>();
        camera = GameObject.Find("Main Camera").transform;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Translate(Vector3.left * 4 * Time.deltaTime * -1);
            this.gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Translate(Vector3.right * 4 * Time.deltaTime);
            this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space) && (isGrounded))
        {
            rig2d.AddForce(new Vector2(0, jumpHeight));
            isGrounded = false;
        }
        if (lifenow <= -1)
        {
            Application.LoadLevel("Lv1");
        }
    }

    internal void ReduceLifenow()  
    {
        if (ctrl == 0)
        {
            ctrl = 1;
            lifenow--;
            this.gameObject.transform.localScale = new Vector3(2.5f, 2.5f, 0);
            StartCoroutine(routines());
        }
    }
    public void AddStar()
    {
        star++;
    }
    IEnumerator routines()
    {
        yield return new WaitForSeconds(2);
        ctrl = 0;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Die"&& ctrl == 0)
        {
            ctrl = 1;
            lifenow--;
            //derecters = 0;
            this.gameObject.transform.localScale = new Vector3(2.5f, 2.5f, 0);
            StartCoroutine(routines());
        }
        if (col.gameObject.tag == "QuickDie")
        {
            Application.LoadLevel("Lv1");
        }
        if (col.gameObject.tag == "IsGrounded")
        {
            isGrounded = true;
        }
        if (col.gameObject.tag == "Shiitake")
        {
            this.gameObject.transform.localScale = new Vector3(4.3f, 4.3f, 0);
            Destroy(col.gameObject);
            lifenow++;
        }
    }
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "2"&& star == 3)
        {
            SceneManager.LoadScene("Lv2");
        }
            if (coll.gameObject.tag == "IsGrounded")
        {
            isGrounded = true;
        }
        if (coll.gameObject.tag == "Star")
        {
            StarController.Instance.Starplus();
            Destroy(coll.gameObject);
        }
        if (coll.gameObject.tag == "Lv1pipe")
        {
            gameObject.transform.position = new Vector3(73.7f, 24, 0);
        }
        if (coll.gameObject.tag == "CanDestroy")
        {
            Destroy(coll.gameObject);
        }
    }
}