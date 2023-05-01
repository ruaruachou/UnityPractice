using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewControl : MonoBehaviour
{
    public float x;
    public float y;
    private Transform cameraTransform;
    // Start is called before the first frame update
    void Start()
    {
        cameraTransform.transform = new Transform();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Mouse X");
        y = Input.GetAxis("Mouse Y");
    }
}
