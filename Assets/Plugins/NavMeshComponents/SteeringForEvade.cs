using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteeringForEvade : MonoBehaviour
{
    public Rigidbody target;
    public float speed = 2;
    public float weight = 0.5f;
    //�����ص�   ���ӻ�����
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
        //���� ע���� �Լ�ǰ��һ���ĽǶ������أ��ڲ�߲�����

        //1 Ŀ����˶���ľ���
        var toTarget = transform.position - target.position;
        var angle = Vector3.Angle(target.velocity.normalized, toTarget);//����Ƕ�
        Vector3 expectForce;
        if (angle > 20 && angle < 160)
        {
            //2 ʱ��
            var targetSpeed = target.velocity.magnitude;
            var time = toTarget.magnitude / (targetSpeed + self.velocity.magnitude);
            //3 �ƶ�ʱ�����ߵľ���
            var runDistance = targetSpeed * time;
            //4 ���ص�λ��
            var interceptPoint = target.position + target.velocity.normalized * runDistance;
            tempPiont = interceptPoint;
            //5 �������ٿ����� = ������ - ���ص㣩.normalized * speed
            expectForce = (transform.position - interceptPoint).normalized * speed;
        }
        else
        {//Զ���㷨
            expectForce = toTarget.normalized * speed;
        }
        //6 ʵ�� = ������ - ��ǰ��* Ȩ��
        return (expectForce - self.velocity) * weight;
    }

}
