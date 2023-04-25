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
    private void Start()
    {
        Enemy[]allEnemies=FindObjectsOfType<Enemy>();
        Enemy min = FindEnemyByMinHp(allEnemies);
        min.GetComponent<MeshRenderer>().material.color = Color.red;
    }

}
