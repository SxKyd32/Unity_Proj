using UnityEngine;
using System.Collections;

public class script1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static void fun(GameObject go)
	{
		go.transform.Rotate(0, 1, 0);
	}
}
