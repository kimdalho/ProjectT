
using System.Collections.Generic;
using UnityEngine;
using static MonsterDataDB;
/// <summary>
/// 몬스터를 생성하는 팩토리를 서비스한다
/// SpanwerManager에서 컨트롤한다.
/// </summary>
/// 
public class MonsterSpawner : MonoBehaviour
{
    public MonsterDataDB monDB
    {
        get { return MonsterDataDB.instance; }
    }


    //디테일한 기획 필요

    //몬스터들은 각기 다른 클래스를 가질것인가.
    public MonsterModel CreateMonster()
    {
        //기획안 없음 
        //생성할 몬스터는 DB에서 랜덤으로 정한다.
        int id = Random.Range(1, MonsterDataDB.instance.monsterDic.Count);

        //생성할 몬스터 정의
        //가능하면 관리가 복잡해지더라도
        //몬스터의 클래스를 따로 두고 생성하고싶다.

        //MonsterModel newMon =  new MonsterModel();

        //생성할 몬스터의 id를 몬스터 열거타입으로 캐스팅
        var info = monDB.monsterDic[(eMonsterType)id];

        //정보의 프리펩에 접근해서 몬스터 생성
        var go =  Instantiate(info.modelPrefab);
        //비어있는 대상에게 정보 삽입
        go.AddComponent<MonsterModel>().info = info;

        MonsterModel newMon = go.GetComponent<MonsterModel>();
        //스포너 관리자에게 반환
        return newMon;
    }
}
