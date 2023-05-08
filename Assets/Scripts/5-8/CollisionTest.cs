using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)//获取被撞物体引用
    {
        other.gameObject.GetComponent<MeshRenderer>().material.color= Color.red;//本物体碰到其他有碰撞器的物体时，其他物体变成红色
        //ContactPoint contactPoint = other.gameObject.GetComponent<ContactPoint>();//获取撞击点的世界坐标
        //contactPoint.normal = Vector3.one;//获取接触面的法线（方向）
    }
}
