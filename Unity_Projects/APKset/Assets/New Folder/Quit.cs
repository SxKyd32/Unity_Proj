using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // 退出程序
    public void BtnQuit()
    {
        // UnityEditor.EditorApplication.isPlaying = false;

        Application.Quit(0);
    }
}
