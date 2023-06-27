using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Input.GetAxis("Horizontal");
        Input.GetAxis("Vertical");
        Input.GetAxis("Mouse X");
        Input.GetAxis("Mouse Y");
        Input.GetAxis("Mouse ScrollWheel");


    }
}
