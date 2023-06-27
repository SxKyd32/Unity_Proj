using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	private void OnGUI()
    {
		if (GUI.Button(new Rect(Screen.width * 9 / 20, Screen.height * 9 / 20,
			Screen.width / 10, Screen.height / 10), "切换场景"))
			SceneManager.LoadScene("procGame");
    }

	// Update is called once per frame
	void Update () {
	
	}
}
