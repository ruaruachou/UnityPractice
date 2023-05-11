using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static PolymorphismFruit;

public class FruitSalad : MonoBehaviour
{
    void Start()
    {
        //��ע�⣬����ı�����myFruit����������
        //Fruit�����Ǳ������˶� Apple �����á�����
        //���ڶ�̬�������õġ����� Apple �� Fruit��
        //��������ǿ��еġ���Ȼ Apple ���ô洢
        //�� Fruit �����У���ֻ���� Fruit һ��ʹ��
        Fruit myFruit = new Apple();

        myFruit.SayHello();
        myFruit.Chop();

        //���Ϊ����ת����Fruit ���͵ı�����myFruit��
        //ʵ���ϰ����� Apple �����á���ˣ�
        //���԰�ȫ�ؽ���ת���� Apple ��������ʹ��
        //�������� Apple һ��ʹ�ã�������ǰֻ���� Fruit
        //һ��ʹ�á�
        Apple myApple = (Apple)myFruit;

        myApple.SayHello();
        myApple.Chop();
    }
}

