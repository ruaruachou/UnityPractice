using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeCount : MonoBehaviour
{
    public int second = 120;
    private TextMeshPro textTimer;
    void Start()
    {
        textTimer = this.GetComponent<TextMeshPro>();
    }

    void Update()
    {
        second--;
        textTimer.text = string.Format("{0:d2}:{1:d2}", second / 60, second % 60);
    }
}
