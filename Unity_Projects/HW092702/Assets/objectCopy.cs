using UnityEngine;
using System.Collections;

public class objectCopy : MonoBehaviour {

	public GameObject go;
	public GameObject goc;
	// Use this for initialization
	void Start () {
		for(int i=1; i<21; i++)
        {
			string str;
			str = i.ToString();
			goc = (GameObject)Instantiate(go, new Vector3(2*i, 0, 0), Quaternion.identity);
			goc.name = "myObject0" + str;
			Debug.Log(goc.name);
		}	

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
