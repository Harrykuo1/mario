using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flower2 : MonoBehaviour
{
    private int Directer = 1;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y >= 3.7f)
        {
            Directer = -1;
        }
        if (gameObject.transform.position.y <= -0.5f)
        {
            Directer = 1;
        }
        gameObject.transform.position += new Vector3(0, 0.03f * Directer, 0);
    }
}
