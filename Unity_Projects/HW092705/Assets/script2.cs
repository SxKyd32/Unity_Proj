using UnityEngine;
using System.Collections;

public class script2 : MonoBehaviour {

	public GameObject go;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		go = GameObject.Find("Cube");
		script1.fun(go);
	}
}
