using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindEnemy : MonoBehaviour
{
    //����������Enemy����HP�������ٵĲ�����
    public Enemy FindEnemyByMinHp(Enemy[] allEnemies)
    {
        Enemy minHPenemy = allEnemies[0];
        for (int i = 1; i < allEnemies.Length; i++)
        {
            if (minHPenemy.HP > allEnemies[i].HP)
            {
                minHPenemy = allEnemies[i];
            }
        }
        return minHPenemy;
    }
    //���������Ҿ��뱾������������Enemy������
    public Enemy FindEnemyByMinDistance(Enemy[] allEnemies)
    {
        Enemy minDisEnemy= allEnemies[0];
        float minDistance=Vector3.Distance(this.transform.position,minDisEnemy.transform.position);
        for (int i = 0; i < allEnemies.Length; i++)
        {
            if (minDistance > Vector3.Distance(this.transform.position, allEnemies[i].transform.position))
            {
                minDistance= Vector3.Distance(this.transform.position, allEnemies[i].transform.position);
                minDisEnemy = allEnemies[i];
            }
        }
        return minDisEnemy;
    }
    private void Start()
    {
        Enemy[] allEnemies = FindObjectsOfType<Enemy>();
        Enemy min = FindEnemyByMinHp(allEnemies);
        Enemy minDisEnemy = FindEnemyByMinDistance(allEnemies);
        min.GetComponent<MeshRenderer>().material.color = Color.red;
        minDisEnemy.GetComponent<MeshRenderer>().material.color = Color.blue;
    }
}
