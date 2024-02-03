using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateLaser : MonoBehaviour {
    public GameObject Bullet;
    float Timer_f = 0f;
    int Timer_i = 0;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        Timer_f += Time.deltaTime;
        Timer_i = (int)Timer_f;
        if (Timer_i == 2)
        {
            Vector3 poss = new Vector3(38f, 15.3f, 0);
            Quaternion po = new Quaternion(0, 0, 120,70);
            Instantiate(Bullet, poss, po);
            Timer_f = 0f;
        }
    }
}
