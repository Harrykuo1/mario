using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    float jumpHeight = 860f;
    bool isGrounded = true;
    Rigidbody2D rig2d;
    // Use this for initialization
    void Start()
    {
        rig2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Translate(Vector3.left * 4 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Translate(Vector3.right * 4 * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space) && (isGrounded))
        {
            rig2d.AddForce(new Vector2(0, jumpHeight));
            isGrounded = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "IsGrounded")
        {
            isGrounded = true;
        }
    }
    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "1"&& Input.GetKeyDown(KeyCode.UpArrow))
        {
            SceneManager.LoadScene("Lv1");
        }
        if (col.gameObject.tag == "2" && Input.GetKeyDown(KeyCode.UpArrow))
        {
            SceneManager.LoadScene("Lv2");
        }
        if (col.gameObject.tag == "3" && Input.GetKeyDown(KeyCode.UpArrow))
        {
            SceneManager.LoadScene("Lv5");
        }
        if (col.gameObject.tag == "4" && Input.GetKeyDown(KeyCode.UpArrow))
        {
            SceneManager.LoadScene("Lv3");
        }
        if (col.gameObject.tag == "5" && Input.GetKeyDown(KeyCode.UpArrow))
        {
            SceneManager.LoadScene("Lv4");
        }
    }
}
