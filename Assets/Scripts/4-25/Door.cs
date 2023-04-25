using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool doorPositionState = false;
    private Animation doorAnim;
    public string animName = "Door";
    private void Start()
    {
        doorAnim= GetComponent<Animation>();   
    }
    private void OnMouseDown()
    {
        if (doorPositionState)
        {
            doorAnim[animName].speed = 1;
        }
        else
        {
            if (doorAnim.isPlaying)//判断是否正在播放，用于在播放过程中临时改变方向倒序播放
            {
                doorAnim[animName].time = doorAnim[animName].length;
            }
            doorAnim[animName].speed = -1;
        }
        doorAnim.Play(animName);
        doorPositionState = !doorPositionState;
    }
}
