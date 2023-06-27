using UnityEngine;
using System.Collections;

public class rotation : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		transform.parent.Rotate(0, 27, 0);
		GameObject Earth = GameObject.Find("Earth");
		transform.RotateAround(Earth.transform.position, Vector3.up, -26);


        transform.Rotate(0, 1, 0);
		
	}
}
