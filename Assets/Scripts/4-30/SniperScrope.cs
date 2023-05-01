using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SniperScrope : MonoBehaviour
{
    private Camera mainCamera;
    public float[] scropeLevel;//创建放大比例数组,用于在inspector面板控制
    private int index;//数组索引
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GetComponent<Camera>();
        mainCamera.fieldOfView = scropeLevel[index];//给相机比例赋数组值
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        { index = (index + 1) % scropeLevel.Length; }//每点击右键,数组索引变化,该写法可防止越界
        mainCamera.fieldOfView = Mathf.Lerp(mainCamera.fieldOfView, scropeLevel[index], 0.1f);//使用插值来调整变化速率
        if (Mathf.Abs(mainCamera.fieldOfView - scropeLevel[index]) < 0.01f) //取整
        {
            mainCamera.fieldOfView = scropeLevel[index];
        }

    }
}
