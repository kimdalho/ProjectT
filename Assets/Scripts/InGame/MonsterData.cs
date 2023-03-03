using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Monster Data", menuName = "Scriptable Object/Monster Data", order = int.MaxValue)]
public class MonsterData : ScriptableObject
{
    public int id;
    public string _name;
    public int hp;
    public int damage;
    //�þ߹���
    public float sightRange;
    //�̵��ӵ�
    public float moveSpeed;
    //��� ������
    public GameObject modelPrefab;
    //���
    public int grade;

}

//��� ��������
//ȹ�� ����ġ�� ��޿� ���� ������ ������.
