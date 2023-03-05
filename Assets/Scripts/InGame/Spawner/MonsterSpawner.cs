
using System;
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
    public BaseToy CreateMonster(int id)
    {
        Debug.Log("테스트" + (eToy)id);

        //기획안 없음 
        //생성할 몬스터는 DB에서 랜덤으로 정한다.
        var info = monDB.monsterStatDic[(eToy)id];

        //정보의 프리펩에 접근해서 몬스터 생성
        var go = Instantiate(info.modelPrefab);
        go.transform.position = this.transform.position;

        //비어있는 대상에게 정보 삽입
        //go.AddComponent<MonsterModel>().info = info;
        var scriptType = monDB.GetTypeMy(info.toyType.ToString());
         go.AddComponent(scriptType);


        //삭제 MonsterModel
        BaseToy newMon = go.GetComponent<BaseToy>();
        newMon.info = info;
        newMon.Setup();
        //스포너 관리자에게 반환
        return newMon;
    }
}
