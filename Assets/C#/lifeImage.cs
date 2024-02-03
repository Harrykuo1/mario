using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class lifeImage : MonoBehaviour {
    public Texture2D Image1;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Sprite s1 = Sprite.Create(Image1, new Rect(0, 0, Image1.width, Image1.height), Vector2.zero);
        GetComponent<Image>().sprite = s1;
    }
}
