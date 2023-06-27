using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        //if (GUI.Button(new Rect(Screen.width / 10, Screen.height / 10, Screen.width / 10, Screen.height / 10), "Ok"))
        //    Application.Quit();

        GUI.Box(new Rect(Screen.width / 10, Screen.height / 10, Screen.width / 5, Screen.height * 3 / 10), " ");
    }



}
