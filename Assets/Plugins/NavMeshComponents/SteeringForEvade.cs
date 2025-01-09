using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteeringForEvade : MonoBehaviour
{
    public Rigidbody target;
    public float speed = 2;
    public float weight = 0.5f;
    //画拦截点   可视化调试
    private Vector3 tempPiont;
    private Rigidbody self;
    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(tempPiont, 0.5f);
    }

    private void Start()
    {
        self = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        self.velocity = GetForce();
    }

    public Vector3 GetForce()
    {
        //拦截 注意在 自己前方一定的角度内拦截，在侧边不拦截

        //1 目标和运动体的距离
        var toTarget = transform.position - target.position;
        var angle = Vector3.Angle(target.velocity.normalized, toTarget);//计算角度
        Vector3 expectForce;
        if (angle > 20 && angle < 160)
        {
            //2 时间
            var targetSpeed = target.velocity.magnitude;
            var time = toTarget.magnitude / (targetSpeed + self.velocity.magnitude);
            //3 推断时间内走的距离
            var runDistance = targetSpeed * time;
            //4 拦截点位置
            var interceptPoint = target.position + target.velocity.normalized * runDistance;
            tempPiont = interceptPoint;
            //5 期望（操控力） = （自身 - 拦截点）.normalized * speed
            expectForce = (transform.position - interceptPoint).normalized * speed;
        }
        else
        {//远离算法
            expectForce = toTarget.normalized * speed;
        }
        //6 实际 = （期望 - 当前）* 权重
        return (expectForce - self.velocity) * weight;
    }

}
