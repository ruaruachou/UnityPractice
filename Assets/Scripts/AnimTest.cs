using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTest : MonoBehaviour
{
    private Animation testAnimation;
    public int speed = 1;
    void Start()
    {
        testAnimation = GetComponent<Animation>();
        testAnimation["Door"].speed= speed;
    }

}
