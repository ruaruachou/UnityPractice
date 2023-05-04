using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class CapsualePlayerContral : MonoBehaviour
{
    public int moveSpeed = 10;//移动速度
    public int rotateSpeed = 10;//旋转速度
    void Start()
    {
        
    }
    void Update()
    {
        float hor = Input.GetAxis("Horizontal");//获取水平方向的值
        float ver = Input.GetAxis("Vertical");//获取垂直方向的值
        if (hor != 0 || ver != 0)//否则会乱跑
        { Movement(hor, ver); }
      
    }
    private void Movement(float hor, float ver)
    {
        Quaternion dir = Quaternion.LookRotation(new Vector3(hor, 0, ver));//（1，0，0）为红轴正1，（0，0，1）为黄轴正1，刚好与GetAxis的值对应
        this.transform.rotation = Quaternion.Lerp(this.transform.rotation, dir, Time.deltaTime*rotateSpeed);
        this.transform.Translate(0,0,Time.deltaTime*moveSpeed);
    }
}
