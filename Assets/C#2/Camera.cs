using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private Transform mario;

    public bool debug;

    // Use this for initialization
    void Start()
    {
        Screen.SetResolution(1920, 1280, true, 60);
        mario = GameObject.Find("Mario").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (mario.position.x + 9 > 0)
        {
            if (mario.position.x - 3 > transform.position.x)
            {
                transform.position = new Vector3(mario.position.x - 3, transform.position.y, -10);
            }
        }
        if (mario.position.x + 4.95f > 0)
        {
            if (mario.position.x + 5 < transform.position.x)
            {
                transform.position = new Vector3(mario.position.x + 5, transform.position.y, -10);
            }
        }
        if (mario.position.y >= 3.9f)
        {
            transform.position = new Vector3(transform.position.x, mario.position.y - 3.8f, -10);
        }
    }
}
