using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneContral : MonoBehaviour
{
    public float flySpeed = 50;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("Horizontal");//��ȡˮƽ�����ֵ
        float ver = Input.GetAxis("Vertical");//��ȡ��ֱ�����ֵ
        Move(hor, ver);
    }
    private void Move(float hor, float ver)
    {

        Vector3 screenPoint = Camera.main.WorldToScreenPoint(this.transform.position);//��ȡ�������Ļ����
        if (screenPoint.x > Screen.width) { screenPoint.x = 0; }//������Ļ�߽�ʱ,����һ�߳���
        if (screenPoint.x < 0) { screenPoint.x = Screen.width; }
        if (screenPoint.y > Screen.height) { screenPoint.y = 0; }
        if (screenPoint.y < 0) { screenPoint.y = Screen.height; }

        transform.position = Camera.main.ScreenToWorldPoint(screenPoint);//����Ļ����ת����������,���ڿ��������ƶ�
        this.transform.Translate(hor*Time.deltaTime*flySpeed, 0, ver*Time.deltaTime*flySpeed);//�ƶ�
    }
}
