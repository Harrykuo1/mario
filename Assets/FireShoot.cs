using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireShoot : MonoBehaviour
{
    public GameObject FireBall;
    int ctrl;
    // Use this for initialization
    void Start()
    {
        ctrl = 0;
    }
    IEnumerator routines()
        {
            ctrl = 1;
            yield return new WaitForSeconds(0.5f);
            Vector3 poss = new Vector3(-4.9f, -3.1f, -5);
            Instantiate(FireBall, poss, Quaternion.identity);
            ctrl = 0;
        }
    // Update is called once per frame
    void Update()
    {
        if (ctrl == 0)
        {
            StartCoroutine(routines());
        }
    }
}
