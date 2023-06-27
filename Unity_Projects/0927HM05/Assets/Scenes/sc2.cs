using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc2 : MonoBehaviour
{
    public GameObject go;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        go = GameObject.Find("Cube");
        sc1.fun(go);
    }
}
