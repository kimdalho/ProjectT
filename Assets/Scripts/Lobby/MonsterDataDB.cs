using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���� �������� ����ִ�.
/// ���� �����ʶ� Ŭ������ dbŬ�������� �����´�.
/// 
/// �������� ���⿡ �ӽ÷� ���� �̸����� �峭������ �����ؼ� ����Ѵ�.
/// </summary>
public class MonsterDataDB : MonoBehaviour
{
    public static MonsterDataDB instance;

    [SerializeField]
    private List<MonsterData> monsterStatList;
    //����Ʈ�� �Ⱦ��� ��ųʸ��� ���� ��������
    //������ �������̴� , ���ͷ������� ����

    public static Dictionary<string, Type> monsterScriptDic;
    public Dictionary<eToy, MonsterData> monsterStatDic = new Dictionary<eToy, MonsterData>();


    //���ͺ� Ŭ������ �����Ѵٸ� ����� �ٲ����
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
        //���� ���� ��ųʸ�
        foreach (var monData in monsterStatList)
        {
            monsterStatDic.Add((eToy)monData.id, monData);
        }
        //���� ��ũ��Ʈ ��ųʸ�
        monsterScriptDic = new Dictionary<string, Type>();
        foreach (eToy enumItem in Enum.GetValues(typeof(eToy)))
        {
            string typeString = enumItem.ToString();
            monsterScriptDic.Add(enumItem.ToString(), Type.GetType(typeString));
        }
    }

    public Type GetTypeMy(string key)
    {
        Type result = monsterScriptDic.ContainsKey(key) ? monsterScriptDic[key] : null;
        return result;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            var test = GetTypeMy("Car");

            var testObj = new GameObject();
            testObj.AddComponent(test);
        }
    }
}

