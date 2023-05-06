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
        float hor = Input.GetAxis("Horizontal");//获取水平方向的值
        float ver = Input.GetAxis("Vertical");//获取垂直方向的值
        Move(hor, ver);
    }
    private void Move(float hor, float ver)
    {

        Vector3 screenPoint = Camera.main.WorldToScreenPoint(this.transform.position);//获取物体的屏幕坐标
        if (screenPoint.x > Screen.width) { screenPoint.x = 0; }//超过屏幕边界时,从另一边出现
        if (screenPoint.x < 0) { screenPoint.x = Screen.width; }
        if (screenPoint.y > Screen.height) { screenPoint.y = 0; }
        if (screenPoint.y < 0) { screenPoint.y = Screen.height; }

        transform.position = Camera.main.ScreenToWorldPoint(screenPoint);//把屏幕坐标转回世界坐标,用于控制物体移动
        this.transform.Translate(hor*Time.deltaTime*flySpeed, 0, ver*Time.deltaTime*flySpeed);//移动
    }
}
