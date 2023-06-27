using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gameScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

    }

	private void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width * 9 / 20, Screen.height * 9 / 20,
            Screen.width / 20, Screen.height / 10), "开始游戏"))
            SceneManager.LoadScene("gameProc");
    }

    // Update is called once per frame
    void Update () {
	
	}
}
