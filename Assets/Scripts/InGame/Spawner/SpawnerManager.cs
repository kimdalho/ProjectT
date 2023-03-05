using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnerManager : MonoBehaviour
{
    public GameObject Spawner;
    public List<Board> spawnerBatchList = new List<Board>();

    //씬에 배치되어있는 스포너를 찾아야하기에 
    //이는 인스펙터에서 정의받는다.
    public List<MonsterSpawner> monsterSpawners = new List<MonsterSpawner>();


    public void Setup()
    {
        //스포너 생성
        CreateSpawner();
    }

    //공장 돌리는 코드
    public void StartWave()
    {
        //생성할 웨이브 몬스터 갯수 50으로 초기화
        int cnt = 50;

        //생성할 갯수가 0보다 크다면 생성
        while (cnt > 0)
        {
            for (int i = 0; i < monsterSpawners.Count; i++)
            {
                if (monsterSpawners.Count == 0)
                    cnt = 0;

                int id = Get_Random_Monster_Id();
                monsterSpawners[i].CreateMonster(id);
                cnt--;
            }
        }
    }
    private void CreateSpawner()
    {
        //4,0 ,0,2 ,4,9
        var _boards = GameManager.Instance.boardMgr.boards;
        spawnerBatchList.Add(_boards[4, 0]);
        spawnerBatchList.Add(_boards[0, 2]);
        spawnerBatchList.Add(_boards[4, 9]);

        foreach (Board curBoard in spawnerBatchList)
        {
            GameManager.Instance.spawnerMgr.CreateMonsterSpawner(curBoard);
        }
    }




    public void CreateMonsterSpawner(Board board)
    {
        MonsterSpawner msp = Instantiate(Spawner).GetComponent<MonsterSpawner>();
        msp.gameObject.transform.position = board.transform.position;
        monsterSpawners.Add(msp);
    }


    private int Get_Random_Monster_Id()
    {
        return Random.Range(1, MonsterDataDB.instance.monsterStatDic.Count);
    }
}
