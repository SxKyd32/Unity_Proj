using UnityEngine;
using System.Collections;

public class HPControl : MonoBehaviour {

	public float totalHP = 100f;
	public float currentHP = 100f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (currentHP >= 0)
        {
			if (Input.GetMouseButtonDown(0)) // 单击鼠标左键每次减少5HP
			{
				currentHP -= 5f;
				transform.localPosition = new Vector3(-400 * (1-(currentHP / totalHP)), 0f, 0f);
			}
        }
	}
}
