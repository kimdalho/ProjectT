using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 몬스터 정보들을 담고있다.
/// 추후 스포너란 클래스가 db클래스에서 가져온다.
/// 
/// 정해진게 없기에 임시로 몬스터 이름들을 장난감으로 지정해서 사용한다.
/// </summary>
public class MonsterDataDB : MonoBehaviour
{
    public static MonsterDataDB instance;

    [SerializeField]
    private List<MonsterData> monsterStatList;
    //리스트를 안쓰고 딕셔너리를 새로 만든이유
    //접근이 직관적이다 , 이터레이팅이 용의

    public static Dictionary<string, Type> monsterScriptDic;
    public Dictionary<eToy, MonsterData> monsterStatDic = new Dictionary<eToy, MonsterData>();


    //몬스터별 클래스가 존재한다면 영어로 바꿔야함
    private void Awake()
    {
        //싱글톤
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
        //몬스터 스텟 딕셔너리
        foreach (var monData in monsterStatList)
        {
            monsterStatDic.Add((eToy)monData.id, monData);
        }
        //몬스터 스크립트 딕셔너리
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

