using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarTrigger : MonoBehaviour
{
    // 玩家
    private GameObject player;
    // 车辆移动脚本
    private CarMove carMove;

    // 设置int值用于控制上下车状态转换
    int a = 0;

    // 车辆上的摄像机
    private GameObject carCamera;

    bool isCar = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        player = GameObject.FindWithTag("Player");
        carMove = transform.GetComponentInChildren<CarMove>();

        // 关闭车辆组件
        transform.GetChild(0).GetChild(0).GetChild(0).gameObject.SetActive(false);
        carMove.enabled = false;
    }



    // Update is called once per frame
    void Update()
    {
        // 按F，int值加1，当int值能够整除2时可进行下车操作
        if (Input.GetKeyDown(KeyCode.F))
        {
            a++;
        }

        if (Input.GetKeyDown(KeyCode.F) && a%2 == 0)
        {
            Down();
        }
    }

    // 上车
    private void OnTriggerStay(Collider other)
    {
        if (!isCar)
        {
            if (other.CompareTag("Player"))
            {
                if (Input.GetKeyDown(KeyCode.F))
                {
                    player.transform.SetParent(transform);
                    player.SetActive(false);
                    transform.GetChild(0).GetChild(0).GetChild(0).gameObject.SetActive(true);
                    carMove.enabled = true;
                    isCar = true;
                }
            }
        }
    }

    // 下车
    void Down()
    {
        if (isCar == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                transform.GetChild(0).GetChild(0).GetChild(0).gameObject.SetActive(false);
                player.SetActive(true);
                // 使人物出现在车的附近
                player.transform.position = transform.GetChild(0).GetChild(1).position + new Vector3(1.5f, 0, 0);
                player.transform.SetParent(transform.parent.parent);
                carMove.enabled = false;
                isCar = false;
            }
        }
    }

}
