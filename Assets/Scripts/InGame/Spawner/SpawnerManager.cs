using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    //씬에 배치되어있는 스포너를 찾아야하기에 
    //이는 인스펙터에서 정의받는다.
    public List<MonsterSpawner> monsterSpawners;

    //공장 돌리는 코드
    public void StartWave()
    {
        //생성할 웨이브 몬스터 갯수 50으로 초기화
        int cnt = 50;

        //생성할 갯수가 0보다 크다면 생성
        while(cnt > 0)
        {
            for (int i = 0; i < monsterSpawners.Count; i++)
            {
                monsterSpawners[i].CreateMonster();
                cnt--;
            }
        }

        
    }
}
