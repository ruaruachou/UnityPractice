using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SniperScrope : MonoBehaviour
{
    private Camera mainCamera;
    public float[] scropeLevel;//�����Ŵ��������,������inspector������
    private int index;//��������
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GetComponent<Camera>();
        mainCamera.fieldOfView = scropeLevel[index];//���������������ֵ
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        { index = (index + 1) % scropeLevel.Length; }//ÿ����Ҽ�,���������仯,��д���ɷ�ֹԽ��
        mainCamera.fieldOfView = Mathf.Lerp(mainCamera.fieldOfView, scropeLevel[index], 0.1f);//ʹ�ò�ֵ�������仯����
        if (Mathf.Abs(mainCamera.fieldOfView - scropeLevel[index]) < 0.01f) //ȡ��
        {
            mainCamera.fieldOfView = scropeLevel[index];
        }

    }
}
