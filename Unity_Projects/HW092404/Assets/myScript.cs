using UnityEngine;
using System.Collections;

public class myScript : MonoBehaviour {

	public GameObject go;

	// Use this for initialization
	void Start () {
	
	}
	
	private void OnGUI()
    {
		go.transform.Rotate(0, 1, 0);
    }

	// Update is called once per frame
	void Update () {
	
	}
}
