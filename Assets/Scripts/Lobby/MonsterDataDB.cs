using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

/// <summary>
/// 몬스터 정보들을 담고있다.
/// 추후 스포너란 클래스가 db클래스에서 가져온다.
/// </summary>
public class MonsterDataDB : MonoBehaviour
{
    public static MonsterDataDB instance;

    [SerializeField]
    private List<MonsterData> MonsterDataList;
    //리스트를 안쓰고 딕셔너리를 새로 만든이유
    //접근이 직관적이다 , 이터레이팅이 용의

    //monsterDic[곰인형]
    public Dictionary<eMonsterType, MonsterData> monsterDic = new Dictionary<eMonsterType, MonsterData>();

    public static Dictionary<string, Type> mDic;


    //몬스터별 클래스가 존재한다면 영어로 바꿔야함
    public enum eMonsterType
    {
        None = 0,
        곰인형 = 1,
        병정 = 2,
        지렁이 = 3,
        비행기 = 4,
        로봇 = 5,
    }

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
        //딕셔너리 완성
        foreach (var monData in MonsterDataList)
        {
            monsterDic.Add((eMonsterType)monData.id, monData);
        }
    }
}
