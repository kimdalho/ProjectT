using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

/// <summary>
/// ���� �������� ����ִ�.
/// ���� �����ʶ� Ŭ������ dbŬ�������� �����´�.
/// </summary>
public class MonsterDataDB : MonoBehaviour
{
    public static MonsterDataDB instance;

    [SerializeField]
    private List<MonsterData> MonsterDataList;
    //����Ʈ�� �Ⱦ��� ��ųʸ��� ���� ��������
    //������ �������̴� , ���ͷ������� ����

    //monsterDic[������]
    public Dictionary<eMonsterType, MonsterData> monsterDic = new Dictionary<eMonsterType, MonsterData>();

    public static Dictionary<string, Type> mDic;


    //���ͺ� Ŭ������ �����Ѵٸ� ����� �ٲ����
    public enum eMonsterType
    {
        None = 0,
        ������ = 1,
        ���� = 2,
        ������ = 3,
        ����� = 4,
        �κ� = 5,
    }

    private void Awake()
    {
        //�̱���
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
        Initalize();
    }
    
    private void Initalize()
    {
        //��ųʸ� �ϼ�
        foreach (var monData in MonsterDataList)
        {
            monsterDic.Add((eMonsterType)monData.id, monData);
        }
    }
}
