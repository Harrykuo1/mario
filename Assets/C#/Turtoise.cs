using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Turtoise : MonoBehaviour
{
    public GameObject AfterTurtoise;
    int count = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Charactor")
        {
            GameObject.Find("Mario").GetComponent<PlayerLv1>().ReduceLifenow();
        }
    }
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Charactor" && count == 0)
        {
            count = 1;
            Destroy(this.gameObject);
            Vector3 pos = this.gameObject.transform.position;
            Instantiate(AfterTurtoise, pos, gameObject.transform.rotation);
        }
    }
}
