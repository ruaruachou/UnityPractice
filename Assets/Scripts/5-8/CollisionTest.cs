using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)//��ȡ��ײ��������
    {
        other.gameObject.GetComponent<MeshRenderer>().material.color= Color.red;//������������������ײ��������ʱ�����������ɺ�ɫ
        //ContactPoint contactPoint = other.gameObject.GetComponent<ContactPoint>();//��ȡײ�������������
        //contactPoint.normal = Vector3.one;//��ȡ�Ӵ���ķ��ߣ�����
    }
}
