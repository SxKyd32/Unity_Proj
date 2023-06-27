using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject go;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnGUI()
    {
        go.transform.Rotate(0, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
