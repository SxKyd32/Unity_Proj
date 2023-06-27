//这个脚本是关于玩家所操作的角色的一系列功能的，包括以下模块：
//1.初始化
//2.移动模块（前后左右移动，跳跃，冲刺）
//3.攻击模块（普通攻击，特殊攻击）
//4.互动模块（招募怪兽，变为驾驶模式，变为骑乘模式）
//5.增益（负面效果）模块

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    private CharacterController CC;
    private bool isJump = false;
    private bool isMove = false;
    public float moveSpeed = 4;     // 移动的速度
    public float jumpSpeed = 4;     // 跳跃的速度
    public float gravity = 3;       // 重力

    private Vector3 moveDirection;

    private float h = 0;
    private float v = 0;
    private Vector3 targetDir;
    private CollisionFlags flags;

    // Start is called before the first frame update
    void Start()
    {
        // 定义第一人称控制器
        CC = this.GetComponent<CharacterController>();

        



    }

    // Update is called once per frame
    void Update()
    {
        // 移动
        PlayerMove();

        // 攻击
        PlayerAttack();

    }

    // 角色移动方法
    private void PlayerMove()
    {
        // 定义WASD键盘控制
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        //float ah = Mathf.Abs(h);
        //float av = Mathf.Abs(v);
        float ah = h < 0 ? -h : h;      // 三目运算符，效率更高
        float av = v < 0 ? -v : v;

        if (ah > 0.1f || av > 0.1f)
        {
            targetDir = new Vector3(h, 0, v);
            transform.LookAt(targetDir + transform.position);
            isMove = true;

            /* 在这里添加移动动画 */


        }

        if (Input.GetButton("Jump") && !isJump)
        {
            isJump = true;
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection.y = jumpSpeed;

            /* 在这里添加跳跃动画 */


        }

        if (isJump)
        {
            // 模拟物理，开始下降
            moveDirection.y -= gravity * Time.deltaTime;
            flags = CC.Move(moveDirection * Time.deltaTime);

            // 人物碰撞到地面
            if (flags == CollisionFlags.Below)
            {
                isJump = false;
            }
        }

        if (isMove)
        {
            CC.Move(transform.forward * moveSpeed * Time.deltaTime);
            isMove = false;
        }
    }

    private void PlayerAttack()
    {

    }

}
