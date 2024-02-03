using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class starimage : MonoBehaviour
{
    public Texture2D Image2;
    void Awake()
    {
        Sprite s2 = Sprite.Create(Image2, new Rect(0, 0, Image2.width, Image2.height), Vector2.zero);
        GetComponent<Image>().sprite = s2;
    }
}