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
            if (doorAnim.isPlaying)//�ж��Ƿ����ڲ��ţ������ڲ��Ź�������ʱ�ı䷽���򲥷�
            {
                doorAnim[animName].time = doorAnim[animName].length;
            }
            doorAnim[animName].speed = -1;
        }
        doorAnim.Play(animName);
        doorPositionState = !doorPositionState;
    }
}
