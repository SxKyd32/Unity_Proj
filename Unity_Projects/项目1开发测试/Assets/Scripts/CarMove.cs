﻿//这个脚本是关于车辆的一系列功能的，包括以下模块：
//1.初始化
//2.移动模块（前后左右移动），不同的车具有不同的速度
//3.耐久度（被攻击或者撞到其他物体后减少），不同的车具有不同的耐久度
//4.油量（油量随驾驶时间减少（按上下键生效））

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    private float y;
    //车辆控制速度参数
    private float speedOne = 0f;    //车辆实时速度
    private float speedMax = 120f;  //车辆最大速度
    private float speedMin = -20f;  //车辆最小速度(倒车最大速度）
    private float speedUpA = 2f;    //车辆加速加速度（A键控制）
    private float speedDownS = 4f;  //车辆减速加速度（S键控制）
    private float speedTend = 0.5f; //无操作实时速度趋于0时加速度
    private float speedBack = 1f;   //车辆倒车加速度

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //鼠标隐藏
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        //按下W键并且速度没达到最大，则速度增加
        if (Input.GetKey(KeyCode.W) && speedOne < speedMax)
        {
            speedOne = speedOne + Time.deltaTime * speedUpA;
        }
        //按下S键并且速度没达到零，则速度减小
        if (Input.GetKey(KeyCode.S) && speedOne > 0f)
        {
            speedOne = speedOne - Time.deltaTime * speedDownS;
        }
        //没有执行速度操作并且速度大于最小速度，则缓慢操作
        if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S) && speedOne > 0f)
        {
            speedOne = speedOne - Time.deltaTime * speedTend;
        }
        if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S) && speedOne < 0f)
        {
            speedOne = speedOne + Time.deltaTime * speedTend;
        }

        //按下S键并且速度没有达到倒车速度最大时，且车辆处于可以倒车状态时车辆倒车
        if (Input.GetKey(KeyCode.S) && speedOne > speedMin && speedOne <= 0)
        {
            speedOne = speedOne - Time.deltaTime * speedBack;
        }

        //按下空格，则汽车停止
        if (Input.GetKey(KeyCode.Space) && speedOne != 0)
        {
            speedOne = Mathf.Lerp(speedOne, 0, 0.4f);
            if (speedOne < 5) speedOne = 0;
        }

        transform.Translate(Vector3.forward * speedOne * Time.deltaTime);
        //使用A和D来控制物体左右旋转
        if (speedOne > 1f || speedOne < -1f)
        {
            y = Input.GetAxis("Horizontal") * 60f * Time.deltaTime;
            transform.Rotate(0, y, 0);
        }
    }
}
