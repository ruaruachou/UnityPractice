using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class CapsualePlayerContral : MonoBehaviour
{
    public int moveSpeed = 10;//�ƶ��ٶ�
    public int rotateSpeed = 10;//��ת�ٶ�
    void Start()
    {
        
    }
    void Update()
    {
        float hor = Input.GetAxis("Horizontal");//��ȡˮƽ�����ֵ
        float ver = Input.GetAxis("Vertical");//��ȡ��ֱ�����ֵ
        if (hor != 0 || ver != 0)//���������
        { Movement(hor, ver); }
      
    }
    private void Movement(float hor, float ver)
    {
        Quaternion dir = Quaternion.LookRotation(new Vector3(hor, 0, ver));//��1��0��0��Ϊ������1����0��0��1��Ϊ������1���պ���GetAxis��ֵ��Ӧ
        this.transform.rotation = Quaternion.Lerp(this.transform.rotation, dir, Time.deltaTime*rotateSpeed);
        this.transform.Translate(0,0,Time.deltaTime*moveSpeed);
    }
}
