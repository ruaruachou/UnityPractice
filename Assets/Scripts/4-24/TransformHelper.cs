using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformHelper:MonoBehaviour
{
    public static Transform GetSon(Transform dadTransform, string sonName)
    {
        Transform sonTransform = dadTransform.Find(sonName);
        if(sonTransform!=null) {return sonTransform;}
        int count = dadTransform.childCount;
        for (int i = 0; i <count; i++)
        {
        sonTransform=GetSon(dadTransform.GetChild(i), sonName);
            if(sonTransform!=null) { return sonTransform; }
        }
        return null;
    }
    private void Start()
    {
        var sonTransform = GetSon(this.transform, "Cube (3)");
        sonTransform.GetComponent<MeshRenderer>().material.color = Color.blue;
    }

}
