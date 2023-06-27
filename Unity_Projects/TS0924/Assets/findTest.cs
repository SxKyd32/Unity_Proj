using UnityEngine;
using System.Collections;

public class findTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		test test = FindObjectOfType<test>();
		Debug.Log(test.gameObject.name);

        test[] tests = FindObjectsOfType<test>();
		foreach(test t in tests)
        {
			Debug.Log(t.gameObject.name);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
