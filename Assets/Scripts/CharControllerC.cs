using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharControllerC : MonoBehaviour
{
    // 声明变量：速度、最大速度、加速度、减速度、旋转速度
    public float speed = 0f;
    public float maxSpeed = 10f;
    public float acceleration = 2f;
    public float deceleration = 3f;
    public float rotationSpeed = 90f;

    // 新增：向上力的大小
    public float upwardForce = 5f;


    // 每帧更新（处理输入与逻辑）
    void Update()
    {
        // 1. 加速/减速逻辑（空格键控制）
        if (Input.GetKey(KeyCode.Space))
        {
            // 未达最大速度则加速
            if (speed < maxSpeed)
            {
                speed += acceleration * Time.deltaTime;
                // 限制速度不超过最大值
                speed = Mathf.Min(speed, maxSpeed);
            }
        }
        else
        {
            // 松开空格则减速
            if (speed > 0)
            {
                speed -= deceleration * Time.deltaTime;
                // 防止速度为负
                speed = Mathf.Max(speed, 0);
            }
        }


        // 2. 向前移动（基于当前速度）
        transform.Translate(Vector3.forward * speed * Time.deltaTime);


        // 3. 左右转向逻辑（左右方向键控制）
        float turnInput = Input.GetAxis("Horizontal"); // 左/右对应-1/1
        if (turnInput != 0)
        {
            // 绕Y轴旋转
            transform.Rotate(Vector3.up * turnInput * rotationSpeed * Time.deltaTime);
        }
    }

    // 触发检测：进入触发区域时执行
    private void OnTriggerEnter(Collider other)
    {
        // （可选）通过标签筛选触发物体，例如标签为"UpTrigger"
        if (other.gameObject.tag == "Logo")
        {
            // 给当前物体施加向上的力（需挂载Rigidbody组件）
            Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(Vector3.up * upwardForce, ForceMode.Impulse);
            }
        }
    }

}