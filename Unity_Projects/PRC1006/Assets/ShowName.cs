using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowName : MonoBehaviour {

	// public Text DisplayBtnText;
	// public Text BtnText { get; set; }

	// Use this for initialization
	void Start () {
		/*
		this.gameObject.GetComponent<Button>().onClick.AddListener(delegate ()
		{
			Text text = this.gameObject.GetComponentInChildren<Text>();
			// BtnText = text;
			// DisplayBtnText.text = BtnText.text;
			Debug.Log(text.ToString());
		}
		);
		*/

		Debug.Log(this.gameObject.GetComponent<Text>().ToString());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
