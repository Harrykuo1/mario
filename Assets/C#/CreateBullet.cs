using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBullet : MonoBehaviour {
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
            Vector3 poss =new Vector3(52, -0.2f, 0);
            Instantiate(Bullet, poss, Quaternion.identity);
            Timer_f = 0f;
        }
	}
}
