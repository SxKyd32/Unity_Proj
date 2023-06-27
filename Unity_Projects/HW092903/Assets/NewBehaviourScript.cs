using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
	Image HP;
	// Use this for initialization
	void Start() {
		HP = GetComponent<Image>();
	}

	// Update is called once per frame
	void Update() {
		if (Input.GetMouseButtonDown(0))
		{
			HP.fillAmount -= 0.01f;
		}
	}
}
