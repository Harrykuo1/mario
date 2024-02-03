using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Bullet;
    float Timer_f = 0f;
    int Timer_i = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Timer_f += Time.deltaTime;
        Timer_i = (int)Timer_f;
        if (Timer_i == 2)
        {
            Vector3 poss = new Vector3(-15, -0.45f, 0);
            Quaternion po = new Quaternion(0, 180, 0, 0);
            Instantiate(Bullet, poss,po);
            Timer_f = 0f;
        }
    }
}
