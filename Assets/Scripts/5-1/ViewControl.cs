using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewControl : MonoBehaviour

{
    public float rotateSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");
        if(x!=0||y!=0)
        Rotate(x,y);
    }

    private void Rotate(float x,float y)
    {
        x *= rotateSpeed;
        y *= rotateSpeed;

        this.transform.Rotate(-y * Time.deltaTime, 0, 0);
        this.transform.Rotate(0, x * Time.deltaTime, 0, Space.World);
    }
}
