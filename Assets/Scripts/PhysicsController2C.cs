using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsController2C : MonoBehaviour
{
    // 物理刚体组件（用于控制物体物理运动）
    private Rigidbody rb;
    // 移动速度（可在Inspector面板调整）
    public float speed = 5f;


    // 初始化：获取物体的Rigidbody组件
    void Start()
    {
        // 自动获取当前物体上的Rigidbody组件
        rb = GetComponent<Rigidbody>();
        // 若物体未挂载Rigidbody，在控制台提示错误
        if (rb == null)
        {
            Debug.LogError("当前物体缺少Rigidbody组件！");
        }
    }


    // 物理帧更新（每帧执行，适合处理物理逻辑）
    void FixedUpdate()
    {
        // 若Rigidbody不存在，跳过逻辑（避免报错）
        if (rb == null) return;

        // 获取键盘输入（WASD对应前后左右）
        float horizontal = Input.GetAxis("Horizontal"); // A/D对应-1/1
        float vertical = Input.GetAxis("Vertical"); // W/S对应1/-1

        // 构建移动方向向量（基于世界坐标系）
        Vector3 moveDirection = new Vector3(horizontal, 0f, vertical).normalized;

        // 给刚体添加力，实现移动（乘Time.fixedDeltaTime保证物理帧稳定）
        rb.AddForce(moveDirection * speed * Time.fixedDeltaTime, ForceMode.Force);
    }
}