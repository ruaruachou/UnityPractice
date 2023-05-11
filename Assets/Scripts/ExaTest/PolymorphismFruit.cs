using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static PolymorphismFruit;

public class PolymorphismFruit : MonoBehaviour
{
    public class Fruit
    {
        public Fruit()
        {
            Debug.Log("1st Fruit Constructor Called");
        }

        public void Chop()
        {
            Debug.Log("The fruit has been chopped.");
        }

        public void SayHello()
        {
            Debug.Log("Hello, I am a fruit.");
        }
    }
}
public class Apple : Fruit
{
    public Apple()
    {
        Debug.Log("1st Apple Constructor Called");
    }

    //Apple 有自己的 Chop() 和 SayHello() 版本。
    //运行脚本时，请注意何时调用
    //Fruit 版本的这些方法以及何时调用
    //Apple 版本的这些方法。
    //此示例使用“new”关键字禁止
    //来自 Unity 的警告，同时不覆盖
    //Apple 类中的方法。
    public new void Chop()
    {
        Debug.Log("The apple has been chopped.");
    }

    public new void SayHello()
    {
        Debug.Log("Hello, I am an apple.");
    }
}



