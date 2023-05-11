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

    //Apple ���Լ��� Chop() �� SayHello() �汾��
    //���нű�ʱ����ע���ʱ����
    //Fruit �汾����Щ�����Լ���ʱ����
    //Apple �汾����Щ������
    //��ʾ��ʹ�á�new���ؼ��ֽ�ֹ
    //���� Unity �ľ��棬ͬʱ������
    //Apple ���еķ�����
    public new void Chop()
    {
        Debug.Log("The apple has been chopped.");
    }

    public new void SayHello()
    {
        Debug.Log("Hello, I am an apple.");
    }
}



