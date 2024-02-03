using UnityEngine;
using UnityEngine.SceneManagement;

public class Loby : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GameStart()
    {
        SceneManager.LoadScene("Select");
    }
    public void Close()
    {
        Application.Quit();
    }
}
