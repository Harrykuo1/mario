using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StarController : MonoBehaviour {
    public static StarController Instance;
    int star=0;
    public Text starview;
    void Start () {
        Instance=this;
    }
	
	// Update is called once per frame
	void Update () {

    }
    public void Starplus()
    {
        star++;
        starview.text = "X " + star;
        GameObject.Find("Mario").GetComponent<PlayerLv1>().AddStar();
    }
}


