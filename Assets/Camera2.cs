using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2 : MonoBehaviour
{
    private Transform mario;

    public bool debug;
    bool ctrl = true;
    // Use this for initialization
    void Start()
    {
        Screen.SetResolution(1920, 1280, true, 60);
        mario = GameObject.Find("Mario").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (mario.position.x > 85&&ctrl)
        {
            ctrl = false;
            transform.position = new Vector3(52.8f, 11.4f, -10);
        }
        if (ctrl)
        {
            if (mario.position.x + 32 > 0)
            {
                if (mario.position.x - 3 > transform.position.x)
                {
                    transform.position = new Vector3(mario.position.x - 3, transform.position.y, -10);
                }
            }
            if (mario.position.x + 19.95f > 0)
            {
                if (mario.position.x + 5 < transform.position.x)
                {
                    transform.position = new Vector3(mario.position.x + 5, transform.position.y, -10);
                }
        }
            if (mario.position.y >= 3.1f)
            {
                transform.position = new Vector3(transform.position.x, mario.position.y - 3f, -10);
            }
        }
        
    }
}
