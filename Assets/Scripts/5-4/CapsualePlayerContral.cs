using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class CapsualePlayerContral : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Movement(hor, ver);
      
    }
    private void Movement(float hor,float ver)
    {
      Quaternion dir=Quaternion.look
    }
}
