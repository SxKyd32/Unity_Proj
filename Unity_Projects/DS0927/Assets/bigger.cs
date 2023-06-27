using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cube;
    public float cubeXSize;
    public float cubeYSize;
    public float cubeZSize;

    public float speedX;
    public float speedY;
    public float speedZ;

    public float i;
    void Start()
    {
        cube = GameObject.Find("Cube");

        //获取方块大小
        float cubeXSize = cube.GetComponent<MeshFilter>().mesh.bounds.size.x * cube.transform.localScale.x;
        float cubeYSize = cube.GetComponent<MeshFilter>().mesh.bounds.size.y * cube.transform.localScale.y;
        float cubeZSize = cube.GetComponent<MeshFilter>().mesh.bounds.size.z * cube.transform.localScale.z;


        // 每3秒放大一倍，所以每秒要除3
        speedX = cubeXSize / 3;
        speedY = cubeYSize / 3;
        speedZ = cubeZSize / 3;

        // 初始化时间戳
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // 如果时间戳小于3s，就继续放大
        if (i <= 3)
        {
            // 放大
            cube.transform.localScale += new Vector3(speedX * Time.deltaTime, speedY * Time.deltaTime, speedZ * Time.deltaTime);
        }

        // 时间戳迭代，每次增加一帧的时间
        i += Time.deltaTime;

    }
}