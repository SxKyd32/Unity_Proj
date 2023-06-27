//这个脚本用于实现通过控制车轮位移的方式来移动车辆，绑在车轮组件上（如果没有车轮组件就绑在车上，但需处理翻车后车辆继续移动的问题）

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{
    // 自身Transform组件和Rigidbody组件
    private Transform mmTransform;
    private Rigidbody mmRigidbody;


    // Start is called before the first frame update
    void Start()
    {
        // 获取自身Transform组件和Rigidbody组件，用于实现移动
        mmTransform = gameObject.GetComponent<Transform>();
        mmRigidbody = gameObject.GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {
        // 移动，实际是实现轮胎的运动
        //CarMove();
    }

    private void CarMove()      // 通过控制车轮运动来控制车辆移动
    {
        // 使用系统预设的wasd控制移动
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(h, 0, v);

        mmRigidbody.MovePosition(mmTransform.position + dir * 0.2f);
    }
}
