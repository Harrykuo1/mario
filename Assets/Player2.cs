﻿using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class Player2 : MonoBehaviour
{
    private Transform camera;
    float jumpHeight = 720f;
    bool isGrounded = true;
    Rigidbody2D rig2d;
    public int lifenows = 0;

    [Header("目前的水平速度")]
    public float speedX;

    [Header("目前的水平方向")]
    public float horizontalDirection;//數值會在 -1~1之間

    const string HORIZONTAL = "Horizontal";

    [Header("水平推力")]
    [Range(0, 150)]
    public float xForce;

    [Header("最大水平速度")]
    public float maxSpeedX;

    float speedY;

    public int WalkMode = 0;
    int ctrl=0;
    public void ControlSpeed()
    {
        speedX = rig2d.velocity.x;
        speedY = rig2d.velocity.y;
        float newSpeedX = Mathf.Clamp(speedX, -maxSpeedX, maxSpeedX);
        rig2d.velocity = new Vector2(newSpeedX, speedY);

    }

    // Use this for initialization
    void Start()
    {
        rig2d = GetComponent<Rigidbody2D>();
        camera = GameObject.Find("Main Camera").transform;
    }

    void MovementX()
    {
        horizontalDirection = Input.GetAxis(HORIZONTAL);
        rig2d.AddForce(new Vector2(xForce * horizontalDirection, 0));
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && (isGrounded))
        {
            rig2d.AddForce(new Vector2(0, jumpHeight));
            isGrounded = false;
        }
        if (WalkMode == 0)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                this.gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            MovementX();
            ControlSpeed();
        }
        if (WalkMode == 1)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                gameObject.transform.Translate(Vector3.left * 4.2f * Time.deltaTime * -1);
                this.gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                gameObject.transform.Translate(Vector3.right * 4.2f * Time.deltaTime);
                this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
            }
        }

        if (lifenows <= -1)
        {
            Application.LoadLevel("Lv2");
        }
    }

    internal void ReduceLifenow()
    {
        lifenows--;
        this.gameObject.transform.localScale = new Vector3(2.5f, 2.5f, 0);

    }
    IEnumerator routines()
    {
        yield return new WaitForSeconds(2);
        ctrl = 0;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Die"&&ctrl == 0)
        {
            lifenows--;
            //derecters = 0;
            this.gameObject.transform.localScale = new Vector3(2.5f, 2.5f, 0);
            StartCoroutine(routines());
        }
        if (col.gameObject.tag == "3")
        {
            Application.LoadLevel("Lv5");
        }
        if (col.gameObject.tag == "QuickDie")
        {
            Application.LoadLevel("Lv2");
        }
        if (col.gameObject.tag == "IsGrounded")
        {
            isGrounded = true;
        }
        if (col.gameObject.tag == "Shiitake")
        {
            this.gameObject.transform.localScale = new Vector3(4.3f, 4.3f, 0);
            Destroy(col.gameObject);
            lifenows++;
        }
        if (col.gameObject.tag == "JumpBoard")
        {
            rig2d.AddForce(new Vector2(jumpHeight, jumpHeight * 1.5f));
        }
        if (col.gameObject.tag == "JumpBoard2")
        {
            rig2d.AddForce(new Vector2(jumpHeight * 1.8f, jumpHeight * 2.1f));
        }
    }
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Star")
        {
            StarController.Instance.Starplus();
            Destroy(coll.gameObject);
        }
        if (coll.gameObject.tag == "Monster")
        {
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
    private void OnCollisionStay2D(Collision2D colll)
    {
        if (colll.gameObject.tag == "IceBoard")
        {
            WalkMode = 1;
            isGrounded = true;
        }
        if (colll.gameObject.tag == "IsGrounded")
        {
            isGrounded = true;
        }
        if (colll.gameObject.tag == "IsGrounded&CanDestroy")
        {
            isGrounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collll)
    {
        if (collll.gameObject.tag == "IceBoard")
        {
            WalkMode = 0;
        }
        if (collll.gameObject.tag == "IsGrounded")
        {
            isGrounded = false;
        }
        if (collll.gameObject.tag == "IsGrounded&CanDestroy")
        {
            isGrounded = false;
        }
    }
    private void OnTriggerStay2D(Collider2D colllll)
    {
        if (colllll.gameObject.tag == "IsGrounded")
        {
            isGrounded = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collllll)
    {
        if (collllll.gameObject.tag == "IsGrounded")
        {
            isGrounded = false;
        }
    }
}
